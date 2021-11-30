using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class AuthData : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            if (!reader.ReadBoolean()) {
                authId = null;
            }
            else { 
                authId = reader.ReadString();
            }
            if (!reader.ReadBoolean()) {
                facebookId = null;
            }
            else { 
                facebookId = reader.ReadString();
            }
            if (!reader.ReadBoolean()) {
                gamecenterId = null;
            }
            else { 
                gamecenterId = reader.ReadString();
            }
            if (!reader.ReadBoolean()) {
                googleId = null;
            }
            else { 
                googleId = reader.ReadString();
            }
            type = reader.ReadEnum<Game.AuthType>();
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            if (authId == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(authId);
            }
            if (facebookId == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(facebookId);
            }
            if (gamecenterId == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(gamecenterId);
            }
            if (googleId == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(googleId);
            }
            writer.Write((Int32)type);
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "authId":
                if (reader.TokenType == JsonToken.Null) {
                    authId = null;
                }
                else { 
                    authId = (string) reader.Value;
                }
                break;
                case "facebookId":
                if (reader.TokenType == JsonToken.Null) {
                    facebookId = null;
                }
                else { 
                    facebookId = (string) reader.Value;
                }
                break;
                case "gamecenterId":
                if (reader.TokenType == JsonToken.Null) {
                    gamecenterId = null;
                }
                else { 
                    gamecenterId = (string) reader.Value;
                }
                break;
                case "googleId":
                if (reader.TokenType == JsonToken.Null) {
                    googleId = null;
                }
                else { 
                    googleId = (string) reader.Value;
                }
                break;
                case "type":
                type = ((string)reader.Value).ParseEnum<Game.AuthType>();
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            if (authId == null)
            {
                writer.WritePropertyName("authId");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("authId");
                writer.WriteValue(authId);
            }
            if (facebookId == null)
            {
                writer.WritePropertyName("facebookId");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("facebookId");
                writer.WriteValue(facebookId);
            }
            if (gamecenterId == null)
            {
                writer.WritePropertyName("gamecenterId");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("gamecenterId");
                writer.WriteValue(gamecenterId);
            }
            if (googleId == null)
            {
                writer.WritePropertyName("googleId");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("googleId");
                writer.WriteValue(googleId);
            }
            writer.WritePropertyName("type");
            writer.WriteValue(type.ToString());
        }
    }
}
#endif