#if SERVER
using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.Threading.Tasks;
using Game;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class ServerPlayerSessionController
    {
        public virtual async System.Threading.Tasks.Task<Game.RemoteMetaResponse> ExecuteCommand(RemoteMetaRequestType _type, BinaryReader reader) 
        {
            switch(_type)
            {
                case RemoteMetaRequestType.DeletePlayer:
                {
                    await DeletePlayer();
                    return RemoteMetaResponse.Complete();
                    break;
                }
                case RemoteMetaRequestType.FlushLocalCommands:
                {
                    await FlushLocalCommands();
                    return RemoteMetaResponse.Complete();
                    break;
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
                    var _result = await DebugAuthenticateMergedPlayer(authId);
                    var _data = new MemoryStream();
                    var writer = new BinaryWriter(_data);
                    _result.Serialize(writer);
                    var _bytes = _data.GetBuffer();
                    return RemoteMetaResponse.Complete(_bytes);
                    break;
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
                    var _result = await Authenticate(sessionId, matchmakeTicket, localCommands, savedModelHash, isTestPlayer);
                    var _data = new MemoryStream();
                    var writer = new BinaryWriter(_data);
                    _result.Serialize(writer);
                    var _bytes = _data.GetBuffer();
                    return RemoteMetaResponse.Complete(_bytes);
                    break;
                }
                case RemoteMetaRequestType.FinishSession:
                {
                    await FinishSession();
                    return RemoteMetaResponse.Complete();
                    break;
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
                    var _result = await GetShortPlayerInfo(playfabID);
                    var _data = new MemoryStream();
                    var writer = new BinaryWriter(_data);
                    _result.Serialize(writer);
                    var _bytes = _data.GetBuffer();
                    return RemoteMetaResponse.Complete(_bytes);
                    break;
                }
                case RemoteMetaRequestType.DebugTimeoutSession:
                {
                    await DebugTimeoutSession();
                    return RemoteMetaResponse.Complete();
                    break;
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
                    var _result = await DebugThrowException(type, riftersErrorMessage);
                    var _data = new MemoryStream();
                    var writer = new BinaryWriter(_data);
                    writer.Write(_result);
                    var _bytes = _data.GetBuffer();
                    return RemoteMetaResponse.Complete(_bytes);
                    break;
                }
                case RemoteMetaRequestType.DebugLaggyCommand:
                {
                    int lagInMS = default;
                    lagInMS = reader.ReadInt32();
                    await DebugLaggyCommand(lagInMS);
                    return RemoteMetaResponse.Complete();
                    break;
                }
            }
            return RemoteMetaResponse.NotFound;
        }
    }
}
#endif
#endif
