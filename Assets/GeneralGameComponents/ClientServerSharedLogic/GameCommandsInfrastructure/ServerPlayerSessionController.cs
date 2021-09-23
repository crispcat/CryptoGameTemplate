using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PlayFab;
using PlayFab.PfEditor.EditorModels;
using UnityEngine;
using ZergRush.CodeGen;
using Random = Unity.Mathematics.Random;

namespace Game
{
    public enum DatabaseKeys
    {
        AllPlayer,
        AllPlayerHash,
        Version,
        IsTestPlayer,
    }

    abstract class AggregatedParam
    {
        public abstract void OnParamValueReceived(float value);
        public abstract void Aggregate();
        public float lastPeriodValue { get; protected set; }
        public float allPeriodsValue { get; protected set; }
        public AggregatedParam(string dimensions) => this.dimensions = dimensions;
        private readonly string dimensions;
        public string Log() => $"{lastPeriodValue} {dimensions} ({allPeriodsValue} {dimensions})";
        public virtual void Reset()
        {
            lastPeriodValue = 0;
            allPeriodsValue = 0;
        }
    }
    class MeanParam : AggregatedParam
    {
        float allPeriodsSum;
        int allPeriodsCount;

        float sum;
        int count;
        public override void OnParamValueReceived(float value)
        {
            sum += value;
            allPeriodsSum += value;
            allPeriodsCount++;
            count++;
        }
        public override void Aggregate()
        {
            lastPeriodValue = sum / count;
            allPeriodsValue = allPeriodsSum / allPeriodsCount;
            sum = 0;
            count = 0;
        }
        public MeanParam(string dimensions) : base(dimensions) { }
        public override void Reset()
        {
            base.Reset();
            allPeriodsSum = 0;
            allPeriodsCount = 0;
            sum = 0;
            count = 0;
        }
    }
    class MaxParam : AggregatedParam
    {
        float max;
        public override void OnParamValueReceived(float value)
        {
            max = Math.Max(value, max);
            allPeriodsValue = Math.Max(value, allPeriodsValue);
        }
        public override void Aggregate()
        {
            lastPeriodValue = max;
            max = 0;
        }
        public MaxParam(string dimensions) : base(dimensions) { }
        public override void Reset()
        {
            base.Reset();
            max = 0;
        }
    }
    class SumParam : AggregatedParam
    {
        float sum;
        public override void OnParamValueReceived(float value)
        {
            sum += value;
            allPeriodsValue += value;
        }
        public override void Aggregate()
        {
            lastPeriodValue = sum;
            sum = 0;
        }
        public SumParam(string dimensions) : base(dimensions) { }
        public override void Reset()
        {
            base.Reset();
            sum = 0;
        }
    }
    [GenTask(GenTaskFlags.CommandsGen)]
    public partial class ServerPlayerSessionController
    {
        public GameSession session;
        public string sessionId => session?.ticket;
        public string playerId => session?.playerId;
        GameModel player;
        public bool authed => session != null;
        private float sessionStartTime = Time.realtimeSinceStartup;
        public float sessionElapsedTime => Time.realtimeSinceStartup - sessionStartTime;

        public void SetPlayerTime(long time)
        {
            if (player != null)
                player.time.currTime = time;
        }

        #region Common

        [GenServerCommand]
        async Task DeletePlayer()
        {
            //await PlayFabAdminAPI.DeletePlayerAsync(new PlayFab.AdminModels.DeletePlayerRequest {PlayFabId = playerId});
            throw new NotImplementedException();
#if ENABLE_PLAYFABADMIN_API
            // await PlayFabAdminAPI.DeletePlayerAsync(new PlayFab.AdminModels.DeletePlayerRequest {PlayFabId = playerId});
            // AddTiming(PlayFabAdminAPI.lastCallTiming);
            // await FinishSessionInternal();
#endif
        }

        async Task<bool> UpdateData(string playerId, Dictionary<DatabaseKeys, object> data)
        {
#if ADMIN
            if (!serverOrAdmin)
            {
                var updatingDataAdmin = await PlayFabAdminAPI.UpdateUserReadOnlyDataAsync(
                    new PlayFab.AdminModels.UpdateUserDataRequest { PlayFabId = playerId, Data = data });
                return !updatingDataAdmin.failed();
            }
#endif
            // var updatingDataServer = await PlayFabServerAPI.UpdateUserReadOnlyDataAsync(
            //     new UpdateUserDataRequest { PlayFabId = playerId, Data = data });
            // return !updatingDataServer.failed();
            return true;
        }

        async Task<Dictionary<DatabaseKeys, object>> LoadData(string playerId, params DatabaseKeys[] keys)
        {
            throw new NotImplementedException();
        }
        
        async Task<T> LoadData<T>(string playerId, DatabaseKeys key)
        {
            throw new NotImplementedException();
        }

        private async Task SavePlayerToDB()
        {
            var success = await UpdateData(playerId, new Dictionary<DatabaseKeys, object>
            {
                {DatabaseKeys.AllPlayer, player},
                {DatabaseKeys.AllPlayerHash, player.CalculateHash()}
            });
            if (!success) Debug.LogError("failed to save player data ");
        }

        public LocalMetaCommandResultType ConsumeCommandsBatch(LocalCommandsBatch localCommandsBatch)
        {
            LocalMetaCommandResultType executionResultType = LocalMetaCommandResultType.Complete;
            int executedCount = 0;
            foreach (var localCommand in localCommandsBatch.items)
            {
                SetPlayerTime(localCommand.time);
                var localCommandResult = player.ExecuteCommand(localCommand);
                // localCommandResult data is ignored, cause its not needed on server, its for view.
                // We need only know whether it failed.
                if (localCommandResult.type != LocalMetaCommandResultType.Complete)
                {
                    executionResultType = LocalMetaCommandResultType.Exception;
                    break;
                }
                executedCount++;
            }
            MetaServerLoadTracking.OnLocalCommandsExecuted(executedCount);
            return executionResultType;
        }

        [GenServerCommand]
        public Task FlushLocalCommands() // Its empty, but still executes local commands batch.
        {
            //player.ExecuteCommand(gameCommand); // LocalMetaCommand gameCommand
            //return CommandConsumeResult.Ok;
            return Task.CompletedTask;
        }

        #endregion

        #region Session start/end

        [GenServerCommand]
        public async Task<AuthResponse> DebugAuthenticateMergedPlayer(string authId)
        {
#if CLIENT
            var session = await PlayfabAuth.AuthenticateAsClient(new AuthData {authId = authId});
            AddTiming(ProdGameClientController.clientAPILastCallTiming);
            return await AuthenticateInternal(session.ticket, string.Empty, new LocalCommandsBatch(), -1, isTestPlayer:true);
#else
            return new AuthResponse();
#endif
        }

        [GenServerCommand]
        public async Task<AuthResponse> Authenticate(string sessionId, string matchmakeTicket,
            LocalCommandsBatch localCommands, ulong savedModelHash, bool isTestPlayer)
            => await AuthenticateInternal(sessionId, matchmakeTicket, localCommands, savedModelHash, isTestPlayer);

        private async Task<(bool authOnPlayfabSuccess, string playfabId)> AuthThroughSessionId(string sessionId)
        {
            // Or auth him through session ticket.
            // var playfabResponse = await PlayFabServerAPI.AuthenticateSessionTicketAsync(
            //     new AuthenticateSessionTicketRequest { SessionTicket = sessionId });
            // var authOnPlayfabSuccess = !playfabResponse.failed();
            // if (!authOnPlayfabSuccess)
            //     throw new GameException(playfabResponse.Error.ToString());
            // var playfabId = playfabResponse.Result.UserInfo.PlayFabId;
            // return (authOnPlayfabSuccess, playfabId);
            throw new NotImplementedException();
        }
        
        public async Task<AuthResponse> AuthenticateInternal(string sessionId, string matchmakeTicket,
            LocalCommandsBatch localCommands, ulong savedModelHash, bool isTestPlayer)
        {
            if (player!=null)
            {
                // Save prev session.
                //if (matchmakeTicket != RemoteMetaRequest.PrevConnectionNoMatchmakeTicket)
                //    Debug.Log($"wrong matchmake ticket {matchmakeTicket}");
                Debug.Log($"player {playerId} authed again");
                await SavePlayerToDB();
            }
            // Authenticate on playfab.
            bool authOnPlayfabSuccess;
            string playfabId;
            if (GameServerSettings.IsInCloud)
            {
                if (matchmakeTicket != RemoteMetaRequest.PrevConnectionNoMatchmakeTicket)
                {
                    throw new NotImplementedException();
                    // var playfabResponse = await PlayFabServerAPI.RedeemMatchmakerTicketAsync(
                    //     new RedeemMatchmakerTicketRequest
                    //     {
                    //         Ticket = matchmakeTicket,
                    //         LobbyId = GameServerSettings.LobbyId
                    //     });
                    // authOnPlayfabSuccess = !playfabResponse.failed();
                    //
                    // if (authOnPlayfabSuccess)
                    // {
                    //     playfabId = playfabResponse.Result.UserInfo.PlayFabId;
                    // }
                    // else
                    // {
                    //     if (playfabResponse.Error.Error == PlayFabErrorCode.GameNotFound)
                    //         (authOnPlayfabSuccess, playfabId) = await AuthThroughSessionId(sessionId);
                    //     else
                    //         throw new GameException(playfabResponse.Error.ToString());
                    // }                    
                } 
                else
                {
                    // When player says he does reconnect, we do not require matchmake ticket.
                    if (authed)
                    {
                        // Just use his prev session.
                        authOnPlayfabSuccess = true;
                        playfabId = session.playerId;
                    }
                    else
                        (authOnPlayfabSuccess, playfabId) = await AuthThroughSessionId(sessionId);
                }
            }
            else
                (authOnPlayfabSuccess, playfabId) = await AuthThroughSessionId(sessionId);

            session = null;
            if (!authOnPlayfabSuccess)
            {
                Debug.Log($"auth failed with ticket = {sessionId}");
                return new AuthResponse();
            }
            else
                session = new GameSession {playerId = playfabId, ticket = sessionId};

            // Load player model.
            var playerFromDB = await LoadData(playerId,
                DatabaseKeys.AllPlayer, DatabaseKeys.AllPlayerHash, DatabaseKeys.IsTestPlayer);
            //ThrowIfError(result);
            player = (GameModel) playerFromDB[DatabaseKeys.AllPlayer];
            string playerRaw = null;
            bool useLocal = false;
            if (player == null)
            {
                player = GameModel.Default();
                playerRaw = player.SaveToBinary().ToBase64();
            }
            else
            {
                try
                {
                    ConsumeCommandsBatch(localCommands);
                    var playerHashAfterLocalCommands = player.CalculateHash();
                    if (playerHashAfterLocalCommands == savedModelHash)
                    {
                        useLocal = true;
                    }
                    else
                    {
                        playerRaw = player.SaveToBinary().ToBase64();
                    }
                }
                catch (Exception e)
                {
                    // Recover player without local commands.
                    player = await LoadData<GameModel>(playerId, DatabaseKeys.AllPlayer);
                }
            }

            // if (isTestPlayer && (playerFromDB==null || !playerFromDB.isTestPlayer))
            //     await PlayerInDatabase.MarkAsTestPlayer(playerId);
            //var tagsResponse = await PlayFabServerAPI.GetPlayerTagsAsync(new GetPlayerTagsRequest { PlayFabId = playerId });
            //Debug.Log("tags = " + tagsResponse.Result.Tags.ConvertAll(longTag=>longTag.Replace("title.5626", "")).PrintCollection());

            return new AuthResponse
            {
                //session = session,
                useLocalModel = useLocal,
                playerRaw = playerRaw,
                //battleRaw = battleRaw,
                serverTime = SystemLayer.ticks
            };
        }

        [GenServerCommand]
        public async Task FinishSession() => await FinishSessionInternal();

        public async Task FinishSessionInternal()
        {
            // No player was created
            if (player == null)
                return;

            await SavePlayerToDB();

            player = null;
            if (GameServerSettings.IsInCloud)
            {
                throw new NotImplementedException();
                // await PlayFabServerAPI.NotifyMatchmakerPlayerLeftAsync(new NotifyMatchmakerPlayerLeftRequest
                // {
                //     LobbyId = GameServerSettings.LobbyId, PlayFabId = playerId
                // });
                // AddTiming(PlayFabServerAPI.lastCallTiming);
            }
        }

        [GenServerCommand]
        public async Task<ShortPlayerInfo> GetShortPlayerInfo(string playfabID)
        {
            if (playfabID != null)
            {
                var player = await LoadData<GameModel>(playfabID, DatabaseKeys.AllPlayer);
                
                Debug.Log("Player for PlayFabID " + playfabID + " = " + player?.displayName);

                if (player != null)
                    return new ShortPlayerInfo {displayName = player.displayName};
            }

            return new ShortPlayerInfo{level = -1};
        }
        #endregion

        #region Debug
        [GenServerCommand] public Task DebugTimeoutSession() => Task.CompletedTask;
        [GenServerCommand] public Task<int> DebugThrowException(ExceptionToThrow type, string riftersErrorMessage)
        {
            List<int> someList;
            switch (type)
            {
                case ExceptionToThrow.None: return Task.FromResult(1);
                case ExceptionToThrow.GameException: throw new GameException(riftersErrorMessage);
                case ExceptionToThrow.NullReference:
                    someList = null;
                    return Task.FromResult(someList.Count);
                case ExceptionToThrow.ArgumentOutOfRange:
                    someList = new List<int>();
                    return Task.FromResult(someList[2]);
            }
            return Task.FromResult(-1);
        }
        [GenServerCommand] public async Task DebugLaggyCommand(int lagInMS) => await Task.Delay(lagInMS);
        #endregion

        public async Task<RemoteMetaResponse> ExecuteCommand(RemoteMetaRequestType requestType, BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}