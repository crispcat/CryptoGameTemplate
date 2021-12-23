using System.Threading.Tasks;

namespace CGT
{
    // I live on merged client and send commands to its merged server.
    public class MergedClientMetaNetworkLayer : ClientMetaNetworkLayer
    {
        public MergedClientMetaNetworkLayer(SessionInfo session) : base(session)
        {
        }
        
        public static async Task<MergedClientMetaNetworkLayer> Create(AuthData overrideAuthData = null)
        {
            var sessionInfo = await ClientMetaNetworkLayer.Authenticate(overrideAuthData);
            return new MergedClientMetaNetworkLayer(sessionInfo);
        }

        ServerMetaNetworkLayer serverNetwork = new ServerMetaNetworkLayer();
        public override async Task<RemoteMetaResponse> CallServerApi(RemoteMetaRequest request)
        {
            // Before sending request to 'server'.
            OnBeforeCommandSent(request);
            // Request 'passes network'.
            // 'Server' counts its timings.
            //serverNetwork.detailedDelays = DelaysLogger.Get();
            var totalServerDelay = DelaysLogger.Get();
            totalServerDelay.OnBeforeStart("merged server responding to client");
            // 'Server' executes commands.
            var response = await serverNetwork.CallServerApi(request);
            // 'Server' counts its timings.
            //response.timings = serverNetwork.detailedDelays.timings.Copy();
            //DelaysLogger.Return(serverNetwork.detailedDelays);
            //serverNetwork.detailedDelays = null;
            var serverLag = totalServerDelay.OnAfterFinish().ms;
            // 'Server' logs its actions.
            serverNetwork.LogSentResponse(request.type, response, serverLag);
            // 'Server' sends data to client.
            OnAfterCommandReceived(request.type, response);
            // Response 'passes network'.
            return response;
        }

    }
}