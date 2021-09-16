using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [AttributeUsage(AttributeTargets.Method)]
    public class GenServerCommand : Attribute {}

    // Former ServerSession

    public class ServerMetaNetworkLayer : MetaNetworkLayer
    {
        public static bool logMetaCommandsOnServer
        {
            get
            {
#if CLIENT
                if (LocalGameSettings.instance.clientTypeCell.value == MetaClientType.MergedServer)
                    return LocalGameSettings.instance.logRemoteGameMetaCommands;
#endif
                return GameServerSettings.logs_enabled;
            }
        }
        public bool log => logMetaCommandsOnServer;
        protected void LogReceivedRequest(RemoteMetaRequest command)
        {
            if (!log) return;
            Debug.Log($"META SERVER RECEIVED RemoteMetaRequest = {command.Log(null)}");
        }
        public void LogSentResponse(RemoteMetaRequestType requestType, RemoteMetaResponse command, int lag)
        {
            if (!log) return;
            Debug.Log($"META SERVER SENT ({lag}ms)  RemoteMetaResponse = {command.Log(requestType)}");
        }

        public ServerPlayerSessionController playerSession { get; private set; } = new ServerPlayerSessionController();

        // public DelaysLogger detailedDelays
        // {
        //     get => playerSession.detailedDelays;
        //     set => playerSession.detailedDelays = value;
        // }

        public override async Task<RemoteMetaResponse> CallServerApi(RemoteMetaRequest request)
        {
            try
            {
                LogReceivedRequest(request);
            }
            catch (Exception e)
            {
                Debug.LogError($"logging request {request.type} failed with error {e.ToError()}");
            }

            RemoteMetaResponse response = null;
            ResetTimeout();
            if (request.type == RemoteMetaRequestType.DebugTimeoutSession)
                timeoutTime = 0; // Kills session by timeout.
            bool isAuthing = request.type == RemoteMetaRequestType.Authenticate ||
                             request.type == RemoteMetaRequestType.DebugAuthenticateMergedPlayer;
            if (!playerSession.authed && !isAuthing)
            {
                response = RemoteMetaResponse.NotAuthed;
            }
            else
            {
                //if (log) Debug.Log($"receiving {request.type} meta game remote command request");            

                bool localBatchOk = false;
                try
                {
                    // Execute local commands.
                    if (!isAuthing) localBatchOk = playerSession.ConsumeCommandsBatch(request.localCommandsBatch).IsOk();
                    else localBatchOk = true;
                }
                catch (Exception e)
                {
                    response = RemoteMetaResponse.LocalBatchException(e.ToError());
                }

                if (localBatchOk)
                {
                    try
                    {
                        // Execute remote command.
                        playerSession.SetPlayerTime(request.time);
                        var reader = ProtocolTools.GetReader(request.args);
                        response = await playerSession.ExecuteCommand(request.type, reader);
                        MetaServerLoadTracking.OnRemoteCommandExecuted();
                    }
                    catch (Exception e)
                    {
                        response = RemoteMetaResponse.RemoteCommandException(e.ToError());
                    }
                }

                //if (log) Debug.Log($"sending {request.type} meta game remote command response");
            }
            return response;
        }

        public ServerMetaNetworkLayer() => ResetTimeout();
        public async Task FinishSession() => await playerSession.FinishSession();

        #region Timeouting

        float timeoutTime;
        void ResetTimeout() => timeoutTime = Time.realtimeSinceStartup + RemoteMetaRequest.MetaSessionTimeoutSeconds;
        public bool timeout => timeoutTime < Time.realtimeSinceStartup;

        #endregion
    }
}