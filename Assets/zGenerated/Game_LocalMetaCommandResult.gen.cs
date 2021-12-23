using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace CGT {

    public partial struct LocalMetaCommandResult
    {
        public void Deserialize(BinaryReader reader) 
        {
            type = reader.ReadEnum<CGT.LocalMetaCommandResultType>();
        }
        public void Serialize(BinaryWriter writer) 
        {
            writer.Write((Byte)type);
        }
        public void ReadFromJson(JsonTextReader reader) 
        {
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var __name = (string) reader.Value;
                    reader.Read();
                    switch(__name)
                    {
                        case "type":
                        type = ((string)reader.Value).ParseEnum<CGT.LocalMetaCommandResultType>();
                        break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) { break; }
            }
        }
        public void WriteJson(JsonTextWriter writer) 
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteValue(type.ToString());
            writer.WriteEndObject();
        }
    }
}
#endif
