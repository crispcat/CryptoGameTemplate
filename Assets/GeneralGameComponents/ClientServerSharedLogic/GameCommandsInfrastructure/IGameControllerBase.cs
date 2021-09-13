using System.Threading.Tasks;
using ZergRush;

namespace Game
{
    public interface IGameControllerBase
    {
        GameModel game { get; }
        Task Exit();
        void OnApplicationPause();
        long metaTime { get; }
        void OnUnityUpdate();
    }
}