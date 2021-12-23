using ZergRush.CodeGen;

namespace CGT
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization)]
    public partial struct LocalMetaCommandResult
    {        
        public LocalMetaCommandResultType type;
        [GenIgnore] public object responseData; // Its just local client data.

        public static LocalMetaCommandResult Exception = new LocalMetaCommandResult { type = LocalMetaCommandResultType.Exception };
        public static LocalMetaCommandResult NotFound = new LocalMetaCommandResult { type = LocalMetaCommandResultType.NotFound };
        public static LocalMetaCommandResult Complete() => new LocalMetaCommandResult { type = LocalMetaCommandResultType.Complete };
        public static LocalMetaCommandResult Complete(object responseData) => new LocalMetaCommandResult { type = LocalMetaCommandResultType.Complete, responseData = responseData };
    }
}