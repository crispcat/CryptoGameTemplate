using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class AuthResponse : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            useLocalModel = reader.ReadBoolean();
            serverTime = reader.ReadInt64();
            if (!reader.ReadBoolean()) {
                playerRaw = null;
            }
            else { 
                playerRaw = reader.ReadString();
            }
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            writer.Write(useLocalModel);
            writer.Write(serverTime);
            if (playerRaw == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(playerRaw);
            }
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "useLocalModel":
                useLocalModel = (System.Boolean)reader.Value;
                break;
                case "serverTime":
                serverTime = (long)(Int64)reader.Value;
                break;
                case "playerRaw":
                if (reader.TokenType == JsonToken.Null) {
                    playerRaw = null;
                }
                else { 
                    playerRaw = (string) reader.Value;
                }
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            writer.WritePropertyName("useLocalModel");
            writer.WriteValue(useLocalModel);
            writer.WritePropertyName("serverTime");
            writer.WriteValue(serverTime);
            if (playerRaw == null)
            {
                writer.WritePropertyName("playerRaw");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("playerRaw");
                writer.WriteValue(playerRaw);
            }
        }
    }
}
#endif
