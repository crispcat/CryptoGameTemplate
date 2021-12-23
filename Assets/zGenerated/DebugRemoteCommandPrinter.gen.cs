using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace CGT {

    public static partial class DebugRemoteCommandPrinter
    {
        public static string PrintArgs(RemoteMetaRequestType __type, byte[] __data) 
        {
            if (__data == null) return "";
            var reader = new BinaryReader(new MemoryStream(__data));
            switch (__type)
            {
                case RemoteMetaRequestType.FlushLocalCommands:
                {
                    return $"";
                }
                case RemoteMetaRequestType.DebugAuthenticateMergedPlayer:
                {
                    string authId = default;
                    if (!reader.ReadBoolean()) {
                        authId = null;
                    }
                    else { 
                        authId = string.Empty;
                        authId = reader.ReadString();
                    }
                    return $"authId: {(authId == null ? "null" : authId.ToString())}; ";
                }
                case RemoteMetaRequestType.ConnectToServer:
                {
                    CGT.SessionInfo session = default;
                    if (!reader.ReadBoolean()) {
                        session = null;
                    }
                    else { 
                        session = new CGT.SessionInfo();
                        session.Deserialize(reader);
                    }
                    LocalCommandsBatch localCommands = default;
                    if (!reader.ReadBoolean()) {
                        localCommands = null;
                    }
                    else { 
                        localCommands = new LocalCommandsBatch();
                        localCommands.Deserialize(reader);
                    }
                    ulong savedModelHash = default;
                    savedModelHash = reader.ReadUInt64();
                    return $"session: {(session == null ? "null" : session.ToString())}; localCommands: {(localCommands == null ? "null" : localCommands.SaveToJsonString())}; savedModelHash: {savedModelHash.ToString()}; ";
                }
                case RemoteMetaRequestType.FinishSession:
                {
                    return $"";
                }
                case RemoteMetaRequestType.GetShortPlayerInfo:
                {
                    string playerId = default;
                    if (!reader.ReadBoolean()) {
                        playerId = null;
                    }
                    else { 
                        playerId = string.Empty;
                        playerId = reader.ReadString();
                    }
                    return $"playerId: {(playerId == null ? "null" : playerId.ToString())}; ";
                }
                case RemoteMetaRequestType.DebugTimeoutSession:
                {
                    return $"";
                }
                case RemoteMetaRequestType.DebugThrowException:
                {
                    CGT.ExceptionToThrow type = default;
                    type = reader.ReadEnum<CGT.ExceptionToThrow>();
                    string riftersErrorMessage = default;
                    if (!reader.ReadBoolean()) {
                        riftersErrorMessage = null;
                    }
                    else { 
                        riftersErrorMessage = string.Empty;
                        riftersErrorMessage = reader.ReadString();
                    }
                    return $"type: {type.ToString()}; riftersErrorMessage: {(riftersErrorMessage == null ? "null" : riftersErrorMessage.ToString())}; ";
                }
                case RemoteMetaRequestType.DebugLaggyCommand:
                {
                    int lagInMS = default;
                    lagInMS = reader.ReadInt32();
                    return $"lagInMS: {lagInMS.ToString()}; ";
                }
            }
            return "invalid command type";
        }
    }
}
#endif
