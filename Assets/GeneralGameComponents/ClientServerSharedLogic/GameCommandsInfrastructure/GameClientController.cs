using System;
using System.Threading.Tasks;
using UnityEngine;
using ZergRush;

namespace Game
{
    public enum RemoteMetaRequestType {}

    public enum RemoteMetaResponseType : byte
    {
        NotFound,
        LocalBatchException,
        Exception,
        NotAuthed,
        Complete
    }
    public class AuthenticationInfo
    {
        
    }
    
    public abstract class MetaNetworkLayer
    {
        public abstract Task<RemoteMetaResponse> CallServerApi(RemoteMetaRequest info);
    }
    
    public interface IGameServer
    {
        Task<MetaNetworkLayer> Authenticate(AuthenticationInfo loginInfo);
        Task Exit();
    }
    
    public abstract class ServerBasedGameController : IGameControllerBase
    {
        public void SinkLocalCommand(LocalMetaCommand command)
        {
            sinkedLocalCommands.items.Add(command);
        }

        public LocalCommandsBatch sinkedLocalCommands;
        public LocalCommandsBatch DrainLocalCommands()
        {
            var commands = sinkedLocalCommands;
            sinkedLocalCommands = new LocalCommandsBatch();
            return commands;
        }
        protected const string localCommandsFileName = "local_commands.bin";
        protected void SaveLocalCommands() => sinkedLocalCommands.SaveToFile(localCommandsFileName, true);
        protected void LoadLocalCommands()
        {
            LocalCommandsBatch loadedBatch;
            if (SerializationTools.LoadFromBinaryFile(localCommandsFileName, out loadedBatch))
                sinkedLocalCommands = loadedBatch;
        }

        public virtual void SavePlayer()
        {
        }

        public abstract long metaTime { get; }
        void UpdateMetaTime()
        {
            player.time.currTime = metaTime;
        }

        public virtual void UnityFrameUpdate()
        {
            try
            {
                if (Input.GetKey(KeyCode.F6))
                {
                    QuitProperly();
                }
                UpdateMetaTime();
            }
            catch (Exception e)
            {
            }
        }

        public async void QuitProperly()
        {
            await Exit();
        }
        
        readonly Cell<GameModel> _gameCell = new Cell<GameModel>();
        public override ICell<GameModel> gameCell => _gameCell;
        public ClientMetaNetworkLayer network;
        public RemoteClientMetaNetworkLayer networkRemote => network as RemoteClientMetaNetworkLayer;
        public RiftersServerAPI serverAPI;
        public PingMetaServerController pingServer { get; private set; }
        public TournamentClientController tournamentController { get; private set; }
        public Cell<GameSession> sessionCell { get; private set; } = new Cell<GameSession>();
        public override GameSession session => sessionCell.value;        

        public override long metaTime
        {
            get
            {
                if (!authed)
                    throw new RiftersException("cant get time");
                return ServerEngine.Time.ticksNow - metaTimeClientShift;
            }
        }

        long metaTimeClientShift;
        
        public GameServerType type { get; private set; }

        public ProdGameClientController(GameServerType type)
        {
            this.type = type;

            _gameCell.value = new GameModel();
            switch (type)
            {
#if MERGED
                case GameServerType.PlayfabMerged:
                    network = new MergedClientMetaNetworkLayer(this);
                    break;
#endif
                case GameServerType.PlayfabLocal:
                case GameServerType.PlayfabRemote:
                    network = new RemoteClientMetaNetworkLayer(!settings.isLoadTest, this);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            tournamentController = new TournamentClientController(this);
            serverAPI = new RiftersServerAPI(network);
            status.Bind(currStatus=> {
                pingServer = null;
                if (currStatus == GameControllerStatus.Operational)
                    OnAuthed();
            });
        }
        void OnAuthed()
        {
            Func<float> getPingInterval;
            if (settings.isLoadTest)
                getPingInterval = () => settings.loadTest.pingInterval;
            else
                getPingInterval = () => (RemoteMetaRequest.MetaSessionTimeoutSeconds - 10);
            pingServer = new PingMetaServerController(this, getPingInterval);
        }

        public override void UnityFrameUpdate()
        {
            base.UnityFrameUpdate();
            network?.Update();
            pingServer?.Update();
            tournamentController.UnityFrameUpdate();
        }

        void ErrorAndRestart(string message, Exception e = null)
        {
            Debug.LogError(message);
            if (e != null)
            {
                Debug.LogException(e);
            }

            status.value = GameControllerStatus.NotInitialized;
        }

        public string remotePlayerModelCache => $"remote_player_{settings?.authData?.value?.authId}.bin";

        public static Timing clientAPILastCallTiming => PlayFabClientAPI.lastCallTiming;

        public async Task Authenticate(AuthData overridenAuthData = null)
        {
//            Debug.Log("ProdGameClientController.Authenticate");
            status.value = GameControllerStatus.Authenticating;
            AuthData authData = settings.authData.value;
            if (overridenAuthData != null)
                authData = overridenAuthData;
            if (authData == null || authData.authId == null)
                authData = AuthData.Default();
            var cachedHash = FileWrapper.Exists(remotePlayerModelCache)
                ? LocalGameSettings.instance.lastRemotePlayerModelHash
                : 0;

            // auth on playfab.            
            sessionCell.value = await PlayfabAuth.AuthenticateAsClient(authData);

            string matchmakeTicket = string.Empty;
            if (networkRemote != null)
                matchmakeTicket = await networkRemote.Connect(type == GameServerType.PlayfabRemote);

            // Auth on server.
            var localCommands = DrainLocalCommands();
            //Debug.Log("drained commands for authing");
            var response =
                await serverAPI.Authenticate(session.ticket, matchmakeTicket, localCommands, cachedHash, GameClientRoot.isTestClient);
            if (response.success)
            {
                //Debug.Log("auth occured"); 
                status.value = GameControllerStatus.ConnectingToServer;
            }
            else
            {
                ErrorAndRestart("could not authenticate", null);
                return;
            }

            metaTimeClientShift = ServerEngine.Time.ticksNow - response.serverTime - serverAPI.lag;

            // loading player       
            if (LocalGameSettings.instance.logRemoteGameMetaCommands)
                Debug.Log($"useLocalModel={response.useLocalModel}");
            if (response.useLocalModel)
            {
                try
                {
                    Utils.LoadBinary(remotePlayerModelCache, out game.player);
                }
                catch (Exception e)
                {
                    LocalGameSettings.instance.lastRemotePlayerModelHash = 0;
                    throw new RiftersException("Cant load local player model, resetting hash in settings");
                }
            }
            else
            {
                try
                {
                    game.player = response.playerRaw.FromBase64().LoadFromBinary<PlayerModel>();
                }
                catch (Exception e)
                {
                    ErrorAndRestart("Cant load local player model", e);
                    return;
                }
            }

            game.SetMultiplayerBattle(response.battleRaw != null
                ? response.battleRaw.FromBase64().LoadFromBinary<BattleParticipation>()
                : null);
            game.player.controllerBase = this;
            status.value = GameControllerStatus.Operational;
        }

        public override async Task Start()
        {
            await SocialUtils.Init();
            LoadLocalCommands();
            await Authenticate();
        }

        public async Task EndSession()
        {
            SavePlayer();
            await serverAPI.FinishSession();
        }

        public override async Task Exit()
        {
            status.value = GameControllerStatus.Closing;
            await serverAPI.FinishSession();
        }

        public override async Task Reset()
        {
            await serverAPI.DeletePlayer();
            await base.Reset();
            FileWrapper.RemoveIfExists(remotePlayerModelCache);
        }

        public override void SavePlayer()
        {
            if (status.value == GameControllerStatus.Operational)
            {
                LocalGameSettings.instance.lastRemotePlayerModelHash = game.player.CalculateHash();
                base.SavePlayer();
                game.player.SaveToFile(remotePlayerModelCache, true);
            }            
        }
        

        public override async Task<bool> HardPurchase(ShopPurchasable item, Product product, bool sandbox)
        {
            var payload = (string)(JObject.Parse(product.receipt).GetValue("Payload") as JValue).Value;
            
            var result = await serverAPI.VerifyIOSInAppPurchaseAndAddMoney(item, payload, sandbox);
            
            if (result.ok == false)
            {
                Debug.LogError($"purchase {item.storeId} verification failed with message: {result.message}");
            }
            else
            {
                Debug.Log($"Purchase {item.storeId} successfully verified");
                analyticsEvents.Send(new RealMoneySpent
                {
                    cents = (int)(product.metadata.localizedPrice * 100),
                    currency = product.metadata.isoCurrencyCode,
                    itemId = item.storeId,
                    itemDesc = $"gems {((GemsPurchasable) item).count}",
                });
                item.Apply(player);
                player.lastAcknowledgedIAPPurchase = result.newPurchaseDate;
            }

            return result.canConfirm;
        }

        public override void OnAppPause()
        {
            if (player == null) return;
            if (player.inTutor == false)
            {
                SavePlayer();                
            }
            SaveLocalCommands();
            networkRemote?.SaveSession();
        }

        public override void BeforeExecutionLocalCommand(LocalMetaCommand command)
        {
        }

        public override void CommandExecutionFailed(LocalMetaCommand command)
        {
            Debug.LogError("execution failed " + command);
        }

        protected override async Task<BattleResult> GetCurrMultiplayerBattleResults()
        {
            return await serverAPI.GetMultiplayerBattleResults(game.currMultiplayerBattle.lobbyId,
                game.currMultiplayerBattle.hostPlayerId);
        }

        protected override async Task<Drop> ApplyMultiPlayerBattleResults(BattleResult result)
        {
            var battle = game.currMultiplayerBattle;
            var drop = await serverAPI.ApplyMultiplayerBattleResults(battle.lobbyId,
                battle.hostPlayerId);
            
            player.ApplyBattleResults(battle.encounter, result, battle.hostPlayerId == playerId); // TODO: Remove when deltas sending implemented.

            await base.ApplyMultiPlayerBattleResults(result);

            return drop;
        }
        protected override async Task<Drop> ApplyTournamentBattleResults(BattleResult result)
        {
            // Apply on server.
            var battle = game.currSinglePlayerBattle;
            var tournamentFromServer = await serverAPI.ApplyTournamentBattleResults(result);
            tournamentController.UpdateDataFromServer(tournamentFromServer);

            // Apply on local model.
            var drop = player.ApplyTournamnetBattleResults(result); // TODO: Remove when deltas sending implemented.

            return drop;
        }
    }
}