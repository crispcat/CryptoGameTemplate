using System;
using System.Threading.Tasks;
using CGT;

namespace CGT
{
    using AWS.Auth;

    public abstract class ClientMetaNetworkLayer : MetaNetworkLayer
    {
        static LocalSettings settings => LocalSettings.Instance;
        public SessionInfo session;

        protected ClientMetaNetworkLayer(SessionInfo session)
        {
            this.session = session;
        }

        public string sessionId => session.sessionId;

        public RemoteMetaRequest PrepareRequest(RemoteMetaRequestType type)
        {
            //long time = controller.metaTime;
            var request = new RemoteMetaRequest
            {
                type = type,
                sessionId = session?.sessionId,
                //time = time
            };
            if (type != RemoteMetaRequestType.ConnectToServer)
            {
                //request.localCommandsBatch = controller.DrainLocalCommands();
                //Debug.Log($"drained commands for preparing request for {type}");
                //Debug.Log($"{request.localCommandsBatch.items.Count} local commands fly to server");
            }            
            return request;
        }
        
        protected static async Task<SessionInfo> Authenticate(AuthData overrideAuthData = null)
        {
            AuthData authData = settings.authData;
            if (overrideAuthData != null)
                authData = overrideAuthData;
            if (authData?.authId == null)
                authData = AuthData.Default();
            
            return await AwsCognitoAuthProvider.AuthenticateAsClient(authData);
        }

        public long lag => 0;
        public virtual void Update() { }
        protected void OnBeforeCommandSent(RemoteMetaRequest command)
        {
            LogSentRequest(command);
        }
        protected void OnAfterCommandReceived(RemoteMetaRequestType requestType, RemoteMetaResponse response)
        {
            LogReceivedResponse(requestType, response, lag);
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
        protected void LogReceivedResponse(RemoteMetaRequestType requestType, RemoteMetaResponse command, long lag)
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
    }
}