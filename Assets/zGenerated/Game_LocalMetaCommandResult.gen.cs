using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial struct LocalMetaCommandResult
    {
        public void Deserialize(BinaryReader reader) 
        {
            type = reader.ReadEnum<Game.LocalMetaCommandResultType>();
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
                        type = ((string)reader.Value).ParseEnum<Game.LocalMetaCommandResultType>();
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
