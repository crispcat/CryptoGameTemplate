using System.Threading.Tasks;
using ZergRush.ReactiveCore;

namespace Game
{
    public enum RemoteMetaRequestType
    {
        Authenticate,
        DebugTimeoutSession,
        DebugAuthenticateMergedPlayer,
        DebugThrowException,
        GetShortPlayerInfo,
        FinishSession,
        DebugLaggyCommand,
        DeletePlayer,
        FlushLocalCommands
    }

    public enum RemoteMetaResponseType : byte
    {
        NotFound,
        LocalBatchException,
        Exception,
        NotAuthed,
        Complete
    }
    public class AuthenticationInfo
    {
        
    }
    
    public abstract class MetaNetworkLayer
    {
        public abstract Task<RemoteMetaResponse> CallServerApi(RemoteMetaRequest info);
    }
    
    public interface IGameServer
    {
        Task<MetaNetworkLayer> Authenticate(AuthenticationInfo loginInfo);
        Task Exit();
    }
}