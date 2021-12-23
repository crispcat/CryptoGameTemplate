using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace CGT {

    public partial class AuthData : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            if (!reader.ReadBoolean()) {
                email = null;
            }
            else { 
                email = reader.ReadString();
            }
            if (!reader.ReadBoolean()) {
                password = null;
            }
            else { 
                password = reader.ReadString();
            }
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
            type = reader.ReadEnum<CGT.AuthType>();
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            if (email == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(email);
            }
            if (password == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(password);
            }
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
                case "email":
                if (reader.TokenType == JsonToken.Null) {
                    email = null;
                }
                else { 
                    email = (string) reader.Value;
                }
                break;
                case "password":
                if (reader.TokenType == JsonToken.Null) {
                    password = null;
                }
                else { 
                    password = (string) reader.Value;
                }
                break;
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
                type = ((string)reader.Value).ParseEnum<CGT.AuthType>();
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            if (email == null)
            {
                writer.WritePropertyName("email");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("email");
                writer.WriteValue(email);
            }
            if (password == null)
            {
                writer.WritePropertyName("password");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("password");
                writer.WriteValue(password);
            }
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
