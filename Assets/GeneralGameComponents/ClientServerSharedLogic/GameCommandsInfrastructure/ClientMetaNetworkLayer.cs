using System;
using System.Threading.Tasks;
using GameTools;
using ZergRush;

namespace Game
{
    public abstract class ClientMetaNetworkLayer : MetaNetworkLayer
    {
        static LocalSettings settings => LocalSettings.Instance;
        protected static Task PlayfabAuth()
        {
            AuthData authData = settings.authData;
            if (overrideAuthData != null)
                authData = overrideAuthData;
            if (authData == null || authData.authId == null)
                authData = AuthData.Default();
            var cachedHash = FileWrapper.Exists(remotePlayerModelCache)
                ? settings.lastRemotePlayerModelHash
                : 0;

            // auth on playfab.            
            var session = await PlayfabAuth.AuthenticateAsClient(authData);
            
        }
        
        public RemoteMetaRequest PrepareRequest(RemoteMetaRequestType type)
        {
            long time = controller.metaTime;
            var request = new RemoteMetaRequest
            {
                type = type,
                sessionId = controller.session?.ticket,
                time = time
            };
            if (type != RemoteMetaRequestType.Authenticate)
            {
                request.localCommandsBatch = controller.DrainLocalCommands();
                //Debug.Log($"drained commands for preparing request for {type}");
                //Debug.Log($"{request.localCommandsBatch.items.Count} local commands fly to server");
            }            
            return request;
        }
        
        protected void LogSentRequest(RemoteMetaRequest command)
        {
            try
            {
                //Debug.Log($"META CLIENT SENT RemoteMetaRequest = {command.Log(controller.player)}");
            }
            catch (Exception e)
            {
                // ignored
            }
        }
        protected void LogReceivedResponse(RemoteMetaRequestType requestType, RemoteMetaResponse command, int lag)
        {
            try
            {
                //Debug.Log($"META CLIENT RECEIVED ({lag}ms) RemoteMetaResponse = {command.Log(requestType)}");
            }
            catch (Exception e)
            {
                // ignored
            }
        }
        public abstract long lag { get; }
        public virtual void Update() { }
        protected void OnBeforeCommandSent(RemoteMetaRequest command)
        {
            LogSentRequest(command);
        }
        protected void OnAfterCommandReceived(RemoteMetaRequestType requestType, RemoteMetaResponse response)
        {
            LogReceivedResponse(requestType, response, lag);
        }
    }
}