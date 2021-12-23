#if SERVER
using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.Threading.Tasks;
using CGT;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace CGT {

    public partial class MetaServerPlayerSessionController
    {
        public virtual async System.Threading.Tasks.Task<CGT.RemoteMetaResponse> ExecuteCommand(RemoteMetaRequestType _type, BinaryReader reader) 
        {
            switch(_type)
            {
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
                    CGT.LocalCommandsBatch localCommands = default;
                    if (!reader.ReadBoolean()) {
                        localCommands = null;
                    }
                    else { 
                        localCommands = new CGT.LocalCommandsBatch();
                        localCommands.Deserialize(reader);
                    }
                    ulong savedModelHash = default;
                    savedModelHash = reader.ReadUInt64();
                    var _result = await ConnectToServer(session, localCommands, savedModelHash);
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
                    string playerId = default;
                    if (!reader.ReadBoolean()) {
                        playerId = null;
                    }
                    else { 
                        playerId = string.Empty;
                        playerId = reader.ReadString();
                    }
                    var _result = await GetShortPlayerInfo(playerId);
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
