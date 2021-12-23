using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace CGT {

    public partial class RemoteMetaResponse : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            type = reader.ReadEnum<CGT.RemoteMetaResponseType>();
            if (!reader.ReadBoolean()) {
                error = null;
            }
            else { 
                error = reader.ReadString();
            }
            if (!reader.ReadBoolean()) {
                responseData = null;
            }
            else { 
                responseData = reader.ReadByteArray();
            }
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            writer.Write((Byte)type);
            if (error == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(error);
            }
            if (responseData == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.WriteByteArray(responseData);
            }
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "type":
                type = ((string)reader.Value).ParseEnum<CGT.RemoteMetaResponseType>();
                break;
                case "error":
                if (reader.TokenType == JsonToken.Null) {
                    error = null;
                }
                else { 
                    error = (string) reader.Value;
                }
                break;
                case "responseData":
                if (reader.TokenType == JsonToken.Null) {
                    responseData = null;
                }
                else { 
                    responseData = ((string)reader.Value).FromBase64();
                }
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            writer.WritePropertyName("type");
            writer.WriteValue(type.ToString());
            if (error == null)
            {
                writer.WritePropertyName("error");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("error");
                writer.WriteValue(error);
            }
            if (responseData == null)
            {
                writer.WritePropertyName("responseData");
                writer.WriteNull();
            }
            else
            {
                writer.WritePropertyName("responseData");
                writer.WriteValue(responseData.ToBase64());
            }
        }
    }
}
#endif
