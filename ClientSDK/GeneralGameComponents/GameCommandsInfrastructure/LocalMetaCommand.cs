using ZergRush;
using ZergRush.CodeGen;

namespace CGT
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization), GenInLocalFolder]
    public partial class LocalMetaCommand
    {
        public LocalMetaCommandType type;
        public int objId;
        public byte[] args;
        public long time;

        public override string ToString()
        {
            return $"{type} to obj:{objId} time:{time} args:{args.PrintCollection("")}";
        }
    }
}