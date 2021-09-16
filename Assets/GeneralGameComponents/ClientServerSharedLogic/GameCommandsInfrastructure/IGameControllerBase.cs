using System.Threading.Tasks;
using ZergRush;
using ZergRush.ReactiveCore;

namespace Game
{
    public interface IGameControllerBase
    {
        GameModel game { get; }
        Task Exit();
        void OnApplicationPause();
        long metaTime { get; }
        void OnUnityUpdate();
        IEventStream<string> RestartNeeded();
    }
}