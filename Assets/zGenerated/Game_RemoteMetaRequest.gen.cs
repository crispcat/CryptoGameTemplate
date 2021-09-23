using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class RemoteMetaRequest : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            localCommandsBatch.Deserialize(reader);
            type = reader.ReadEnum<Game.RemoteMetaRequestType>();
            time = reader.ReadInt64();
            if (!reader.ReadBoolean()) {
                args = null;
            }
            else { 
                args = reader.ReadByteArray();
            }
            if (!reader.ReadBoolean()) {
                sessionId = null;
            }
            else { 
                sessionId = reader.ReadString();
            }
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            localCommandsBatch.Serialize(writer);
            writer.Write((Int32)type);
            writer.Write(time);
            if (args == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.WriteByteArray(args);
            }
            if (sessionId == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(sessionId);
            }
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "localCommandsBatch":
                localCommandsBatch.ReadFromJson(reader);
                break;
                case "type":
                type = ((string)reader.Value).ParseEnum<Game.RemoteMetaRequestType>();
                break;
                case "time":
                time = (long)(Int64)reader.Value;
                break;
                case "args":
                if (reader.TokenType == JsonToken.Null) {
                    args = null;
                }
                else { 
                    args = ((string)reader.Value).FromBase64();
                }
                break;
                case "sessionId":
                if (reader.TokenType == JsonToken.Null) {
                    sessionId = null;
                }
                else { 
                    sessionId = (string) reader.Value;
                }
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            writer.WritePropertyName("localCommandsBatch");
            localCommandsBatch.WriteJson(writer);
            writer.WritePropertyName("type");
            writer.WriteValue(type.ToString());
            writer.WritePropertyName("time");
            writer.WriteValue(time);
            if (args == null)
            {
                writer.WritePropertyName("args");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("args");
                writer.WriteValue(args.ToBase64());
            }
            if (sessionId == null)
            {
                writer.WritePropertyName("sessionId");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("sessionId");
                writer.WriteValue(sessionId);
            }
        }
    }
}
#endif
