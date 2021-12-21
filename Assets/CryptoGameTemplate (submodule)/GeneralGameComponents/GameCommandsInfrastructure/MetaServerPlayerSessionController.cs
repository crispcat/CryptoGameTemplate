using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using ZergRush.CodeGen;

namespace Game
{
    [GenTask(GenTaskFlags.CommandsGen)]
    public partial class MetaServerPlayerSessionController
    {
        public SessionInfo session;
        public string PlayerId => session?.playerId;
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
        
        async Task<bool> UpdateData(string playerId, Dictionary<DatabaseKeys, object> data)
        {
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
            var success = await UpdateData(PlayerId, new Dictionary<DatabaseKeys, object>
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
            // Auth
#else
            return new AuthResponse();
#endif
        }
        
        [GenServerCommand]
        public async Task<AuthResponse> ConnectToServer(SessionInfo session, LocalCommandsBatch localCommands, ulong savedModelHash)
            => await AuthenticateInternal(session, localCommands, savedModelHash);

        private async Task<(bool authSuccess, string playerId)> AuthThroughSessionId(string sessionId)
        {
            throw new NotImplementedException();
        }
        
        public async Task<AuthResponse> AuthenticateInternal(SessionInfo session, LocalCommandsBatch localCommands, ulong savedModelHash) 
        {
            if (player != null)
            {
                Debug.Log($"player {PlayerId} authed again");
                await SavePlayerToDB();
            }
            
            bool authSuccess;
            string playerId;
            if (GameServerSettings.IsInCloud)
            {
                if (session.sessionId != RemoteMetaRequest.DefaultSessionId)
                {
                    // Call game session placement.
                    throw new NotImplementedException();
                } 
                else
                {
                    // When player says he does reconnect, we do not require session id.
                    if (authed)
                    {
                        // Just use his prev session.
                        authSuccess = true;
                        playerId = session.playerId;
                    }
                    else
                        (authSuccess, playerId) = await AuthThroughSessionId(session.sessionId);
                }
            }
            else
                (authSuccess, playerId) = await AuthThroughSessionId(session.sessionId);
            
            if (!authSuccess)
            {
                Debug.Log($"auth failed with session id = {(session == null ? "session is null" : session.sessionId)}");
                return new AuthResponse();
            }

            // Load player model.
            var playerFromDB = await LoadData(PlayerId,
                DatabaseKeys.AllPlayer, DatabaseKeys.AllPlayerHash, DatabaseKeys.IsTestPlayer);
            
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
                    player = await LoadData<GameModel>(PlayerId, DatabaseKeys.AllPlayer);
                }
            }

            return new AuthResponse
            {
                useLocalModel = useLocal,
                playerRaw = playerRaw,
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
            }
        }

        [GenServerCommand]
        public async Task<ShortPlayerInfo> GetShortPlayerInfo(string playerId)
        {
            if (playerId != null)
            {
                var player = await LoadData<GameModel>(playerId, DatabaseKeys.AllPlayer);
                
                Debug.Log("Player for PlayFabID " + playerId + " = " + player?.displayName);

                if (player != null)
                    return new ShortPlayerInfo { displayName = player.displayName };
            }

            return new ShortPlayerInfo { level = -1 };
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
}