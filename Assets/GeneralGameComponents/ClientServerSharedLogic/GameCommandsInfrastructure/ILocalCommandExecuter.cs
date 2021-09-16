using System.IO;

namespace Game
{
    public interface ILocalCommandExecuter
    {
#if JSON_PROTOCOL
        LocalMetaCommandResult ExecuteCommand(LocalMetaCommandType type, JsonTextReader reader);
#else
        LocalMetaCommandResult ExecuteCommand(LocalMetaCommandType type, BinaryReader reader);
#endif
    }
}