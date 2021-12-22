using System;
using System.Threading.Tasks;
using GameTools;
using UnityEngine;
using ZergRush;
using ZergRush.CodeGen;
using ZergRush.ReactiveCore;

namespace Game
{
    public class ServerBasedGameController : IGameControllerBase, IGameCommandSink
    {
        ClientMetaNetworkLayer network;
        GameServerAPI serverAPI;
        
        long metaTimeClientShift;
        EventStream<string> restartNeeded = new EventStream<string>();
        
        static LocalSettings settings => LocalSettings.Instance;
        
        public static string remoteGameModelCache => $"remote_player_{settings?.authData?.authId}.bin";

        protected ServerBasedGameController() {}
        // Can only be created with this function
        public static async Task<ServerBasedGameController> Create(ClientMetaNetworkLayer network)
        {
            var controller = new ServerBasedGameController();
            var serverAPI = new GameServerAPI(network);
            controller.serverAPI = serverAPI;
            await controller.ConnectToServer();
            return controller;
        }

        async Task ConnectToServer()
        {
            LoadLocalCommands();
            // Auth on server.
            var localCommands = DrainLocalCommands();
            //Debug.Log("drained commands for authing");

            var response = await serverAPI.ConnectToServer(network.session, localCommands, LocalSettings.Instance.lastRemoteGameModelHash);
            
            metaTimeClientShift = SystemLayer.ticks - response.serverTime - serverAPI.lag;

            // loading player       
            if (settings.logRemoteGameMetaCommands)
                Debug.Log($"useLocalModel={response.useLocalModel}");
            if (response.useLocalModel)
            {
                try
                {
                    SerializationTools.LoadFromBinaryFile(remoteGameModelCache, out GameModel g);
                    game = g;
                }
                catch (Exception e)
                {
                    LocalSettings.Instance.lastRemoteGameModelHash = 0;
                    throw new GameException("Cant load local player model, resetting hash in settings");
                }
            }
            else
            {
                try
                {
                    game = response.playerRaw.FromBase64().LoadFromBinary<GameModel>();
                }
                catch (Exception e)
                {
                    ErrorAndRestart("Cant load local player model", e);
                    return;
                }
            }

            game.controllerBase = this;
        }
        
        public async Task Exit()
        {
            SaveGame();
            await serverAPI.FinishSession();
        }
        
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

        void UpdateMetaTime()
        {
            game.time.currTime = metaTime;
        }

        public long metaTime => SystemLayer.ticks - metaTimeClientShift;

        public void OnUnityUpdate()
        {
            try
            {
                network?.Update();
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

        public IEventStream<string> RestartNeeded() => restartNeeded;

        public async void QuitProperly()
        {
            await Exit();
        }

        public void OnApplicationPause()
        {
            throw new NotImplementedException();
        }


        void ErrorAndRestart(string message, Exception e = null)
        {
            Debug.LogError(message);
            if (e != null)
            {
                Debug.LogException(e);
            }
            restartNeeded.Send(message);
        }


        public GameModel game { get; set; }

        public void SaveGame()
        {
            SaveLocalCommands();
            LocalSettings.Instance.lastRemoteGameModelHash = game.CalculateHash();
            game.SaveToFile(remoteGameModelCache, true);
        }

        public void OnAppPause()
        {
            SaveGame();
            //networkRemote?.SaveSession();
        }

        public void BeforeExecutionLocalCommand(LocalMetaCommand command)
        {
        }

        public void CommandExecutionFailed(LocalMetaCommand command)
        {
            Debug.LogError("execution failed " + command);
        }
    }
}