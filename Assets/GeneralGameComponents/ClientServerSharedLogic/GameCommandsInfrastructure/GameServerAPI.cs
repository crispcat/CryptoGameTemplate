using System.Threading.Tasks;
using ZergRush;
using ZergRush.CodeGen;

namespace Game
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization)]
    public partial class AuthResponse
    {
        public bool useLocalModel;
        public long serverTime;
        [CanBeNull] public string playerRaw;
    }
    
    public partial class GameServerAPI 
    {
        ClientMetaNetworkLayer network;
        public GameServerAPI(ClientMetaNetworkLayer network) => this.network = network;
        // async Task<RemoteMetaResponse> TryResendIfNotAuthed(RemoteMetaRequest request, RemoteMetaResponse response)
        // {
        //     if (response.type != RemoteMetaResponseType.NotAuthed)
        //         return response;
        //     await (network.controller).Authenticate();
        //     response = await network.CallServerApi(request);
        //     if (response.type == RemoteMetaResponseType.NotAuthed)
        //         throw new ZergRushException("cant authenticate twice");
        //     return response;
        // }
        public long lag => network.lag;

        public async Task<AuthResponse> Authenticate(LocalCommandsBatch localCommands, object cachedHash, object isTestClient)
        {
            throw new System.NotImplementedException();
        }

        async Task<RemoteMetaResponse> TryResendIfNotAuthed(RemoteMetaRequest command, RemoteMetaResponse result)
        {
            throw new System.NotImplementedException();
        }
    }
}