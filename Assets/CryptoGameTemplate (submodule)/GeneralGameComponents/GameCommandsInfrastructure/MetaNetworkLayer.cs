using System.Threading.Tasks;
using ZergRush.ReactiveCore;

namespace Game
{
    public abstract class MetaNetworkLayer
    {
        public abstract Task<RemoteMetaResponse> CallServerApi(RemoteMetaRequest info);
    }
}