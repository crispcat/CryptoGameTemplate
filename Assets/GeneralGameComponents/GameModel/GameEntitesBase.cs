using ZergRush.Alive;
using ZergRush.CodeGen;

namespace CGT
{
    [GenTask(GenTaskFlags.LivableNodePack), RootType(typeof(GameModel)), ConfigRootType(typeof(GameConfig))]
    public partial class GameEntity : Livable
    {
        public GameModel game => ((GameModel) root);
    }
    
    [HasRefId]
    public partial class GameReferencableEntity : GameEntity
    {
        public int id;
    }
    
    [GenTask(GenTaskFlags.PolymorphicDataPack), ConfigRootType(typeof(GameConfig))]
    public partial class GameData
    {
    }
}