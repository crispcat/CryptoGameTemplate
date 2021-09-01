using ZergRush.CodeGen;

namespace Game
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization)]
    public partial class LocalMetaCommand
    {
        public LocalMetaCommandType type;
        public int objId;
        public byte[] args;
        public long time;
    }
}