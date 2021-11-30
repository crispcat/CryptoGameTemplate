using ZergRush.Alive;
using ZergRush.CodeGen;

namespace Game
{
    [GenTask(GenTaskFlags.ConfigData), ConfigRootType(typeof(GameConfig))]
    public partial class GameConfigEntity
    {
    }
    
    [GenTask(GenTaskFlags.ConfigData), ConfigRootType(typeof(GameConfig))]
    public partial class GameLoadableConfigEntity : LoadableConfig
    {
    }
    
    public partial class LoadableConfigStub : GameLoadableConfigEntity
    {
    }
}