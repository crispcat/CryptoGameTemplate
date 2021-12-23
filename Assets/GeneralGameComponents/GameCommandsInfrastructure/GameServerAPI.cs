using System.Threading.Tasks;
using ZergRush;
using ZergRush.CodeGen;

namespace CGT
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization), GenInLocalFolder]
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
        public long lag => network.lag;
        // public async Task<AuthResponse> Authenticate(LocalCommandsBatch localCommands, object cachedHash, object isTestClient)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}