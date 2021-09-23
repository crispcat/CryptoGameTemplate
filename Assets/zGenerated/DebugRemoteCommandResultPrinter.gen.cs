using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public static partial class DebugRemoteCommandResultPrinter
    {
        public static string PrintResult(RemoteMetaRequestType __type, byte[] __data) 
        {
            if (__data == null) return "";
            var reader = new BinaryReader(new MemoryStream(__data));
            switch (__type)
            {
                case RemoteMetaRequestType.DeletePlayer:
                return "void";
                case RemoteMetaRequestType.FlushLocalCommands:
                return "void";
                case RemoteMetaRequestType.DebugAuthenticateMergedPlayer:
                {
                    Game.AuthResponse result = default;
                    result = new Game.AuthResponse();
                    result.Deserialize(reader);
                    return result.SaveToJsonString();
                }
                case RemoteMetaRequestType.Authenticate:
                {
                    Game.AuthResponse result = default;
                    result = new Game.AuthResponse();
                    result.Deserialize(reader);
                    return result.SaveToJsonString();
                }
                case RemoteMetaRequestType.FinishSession:
                return "void";
                case RemoteMetaRequestType.GetShortPlayerInfo:
                {
                    Game.ShortPlayerInfo result = default;
                    result.Deserialize(reader);
                    return result.ToString();
                }
                case RemoteMetaRequestType.DebugTimeoutSession:
                return "void";
                case RemoteMetaRequestType.DebugThrowException:
                {
                    int result = default;
                    result = reader.ReadInt32();
                    return result.ToString();
                }
                case RemoteMetaRequestType.DebugLaggyCommand:
                return "void";
            }
            throw new GameException("command id not found");
        }
    }
}
#endif
