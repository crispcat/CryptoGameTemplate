using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class GameServerAPI
    {
        public async System.Threading.Tasks.Task FlushLocalCommands() 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.FlushLocalCommands);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command FlushLocalCommands execution failed, request args: , \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
        }
        public async System.Threading.Tasks.Task<Game.AuthResponse> DebugAuthenticateMergedPlayer(System.String authId) 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.DebugAuthenticateMergedPlayer);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            if (authId == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(authId);
            }
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
                var reader = new BinaryReader(new MemoryStream(_result.responseData));
                Game.AuthResponse parsedResult = default;
                parsedResult = new Game.AuthResponse();
                parsedResult.Deserialize(reader);
                return parsedResult;
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command DebugAuthenticateMergedPlayer execution failed, request args: {authId}, \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
            return default(Game.AuthResponse);
        }
        public async System.Threading.Tasks.Task<Game.AuthResponse> ConnectToServer(Game.SessionInfo session, Game.LocalCommandsBatch localCommands, System.UInt64 savedModelHash) 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.ConnectToServer);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            if (session == null) writer.Write(false);
            else {
                writer.Write(true);
                session.Serialize(writer);
            }
            if (localCommands == null) writer.Write(false);
            else {
                writer.Write(true);
                localCommands.Serialize(writer);
            }
            writer.Write(savedModelHash);
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
                var reader = new BinaryReader(new MemoryStream(_result.responseData));
                Game.AuthResponse parsedResult = default;
                parsedResult = new Game.AuthResponse();
                parsedResult.Deserialize(reader);
                return parsedResult;
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command ConnectToServer execution failed, request args: {session}, {localCommands}, {savedModelHash}, \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
            return default(Game.AuthResponse);
        }
        public async System.Threading.Tasks.Task FinishSession() 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.FinishSession);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command FinishSession execution failed, request args: , \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
        }
        public async System.Threading.Tasks.Task<Game.ShortPlayerInfo> GetShortPlayerInfo(System.String playerId) 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.GetShortPlayerInfo);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            if (playerId == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(playerId);
            }
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
                var reader = new BinaryReader(new MemoryStream(_result.responseData));
                Game.ShortPlayerInfo parsedResult = default;
                parsedResult.Deserialize(reader);
                return parsedResult;
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command GetShortPlayerInfo execution failed, request args: {playerId}, \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
            return default(Game.ShortPlayerInfo);
        }
        public async System.Threading.Tasks.Task DebugTimeoutSession() 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.DebugTimeoutSession);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command DebugTimeoutSession execution failed, request args: , \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
        }
        public async System.Threading.Tasks.Task<int> DebugThrowException(Game.ExceptionToThrow type, System.String riftersErrorMessage) 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.DebugThrowException);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            writer.Write((Int32)type);
            if (riftersErrorMessage == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(riftersErrorMessage);
            }
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
                var reader = new BinaryReader(new MemoryStream(_result.responseData));
                int parsedResult = default;
                parsedResult = reader.ReadInt32();
                return parsedResult;
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command DebugThrowException execution failed, request args: {type}, {riftersErrorMessage}, \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
            return default(int);
        }
        public async System.Threading.Tasks.Task DebugLaggyCommand(System.Int32 lagInMS) 
        {
            var command = network.PrepareRequest(RemoteMetaRequestType.DebugLaggyCommand);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            writer.Write(lagInMS);
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                var _result = await network.CallServerApi(command);
                if (!_result.success) throw new GameException(_result.error);
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Remote command DebugLaggyCommand execution failed, request args: {lagInMS}, \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
            }
        }
    }
}
#endif
