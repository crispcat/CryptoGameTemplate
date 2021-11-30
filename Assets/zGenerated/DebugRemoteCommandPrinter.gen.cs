using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public static partial class DebugRemoteCommandPrinter
    {
        public static string PrintArgs(RemoteMetaRequestType __type, byte[] __data) 
        {
            if (__data == null) return "";
            var reader = new BinaryReader(new MemoryStream(__data));
            switch (__type)
            {
                case RemoteMetaRequestType.DeletePlayer:
                {
                    return $"";
                }
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
                case RemoteMetaRequestType.Authenticate:
                {
                    string sessionId = default;
                    if (!reader.ReadBoolean()) {
                        sessionId = null;
                    }
                    else { 
                        sessionId = string.Empty;
                        sessionId = reader.ReadString();
                    }
                    string matchmakeTicket = default;
                    if (!reader.ReadBoolean()) {
                        matchmakeTicket = null;
                    }
                    else { 
                        matchmakeTicket = string.Empty;
                        matchmakeTicket = reader.ReadString();
                    }
                    Game.LocalCommandsBatch localCommands = default;
                    if (!reader.ReadBoolean()) {
                        localCommands = null;
                    }
                    else { 
                        localCommands = new Game.LocalCommandsBatch();
                        localCommands.Deserialize(reader);
                    }
                    ulong savedModelHash = default;
                    savedModelHash = reader.ReadUInt64();
                    System.Boolean isTestPlayer = default;
                    isTestPlayer = reader.ReadBoolean();
                    return $"sessionId: {(sessionId == null ? "null" : sessionId.ToString())}; matchmakeTicket: {(matchmakeTicket == null ? "null" : matchmakeTicket.ToString())}; localCommands: {(localCommands == null ? "null" : localCommands.SaveToJsonString())}; savedModelHash: {savedModelHash.ToString()}; isTestPlayer: {isTestPlayer.ToString()}; ";
                }
                case RemoteMetaRequestType.FinishSession:
                {
                    return $"";
                }
                case RemoteMetaRequestType.GetShortPlayerInfo:
                {
                    string playfabID = default;
                    if (!reader.ReadBoolean()) {
                        playfabID = null;
                    }
                    else { 
                        playfabID = string.Empty;
                        playfabID = reader.ReadString();
                    }
                    return $"playfabID: {(playfabID == null ? "null" : playfabID.ToString())}; ";
                }
                case RemoteMetaRequestType.DebugTimeoutSession:
                {
                    return $"";
                }
                case RemoteMetaRequestType.DebugThrowException:
                {
                    Game.ExceptionToThrow type = default;
                    type = reader.ReadEnum<Game.ExceptionToThrow>();
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
