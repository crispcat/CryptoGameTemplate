using System.Threading.Tasks;
using ZergRush.ReactiveCore;

namespace CGT
{
    public abstract class MetaNetworkLayer
    {
        public abstract Task<RemoteMetaResponse> CallServerApi(RemoteMetaRequest info);
    }
}