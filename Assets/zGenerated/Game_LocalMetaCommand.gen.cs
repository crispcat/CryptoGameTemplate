using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class LocalMetaCommand : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            type = reader.ReadEnum<Game.LocalMetaCommandType>();
            objId = reader.ReadInt32();
            args = reader.ReadByteArray();
            time = reader.ReadInt64();
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            writer.Write((Int32)type);
            writer.Write(objId);
            writer.WriteByteArray(args);
            writer.Write(time);
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "type":
                type = ((string)reader.Value).ParseEnum<Game.LocalMetaCommandType>();
                break;
                case "objId":
                objId = (int)(Int64)reader.Value;
                break;
                case "args":
                args = ((string)reader.Value).FromBase64();
                break;
                case "time":
                time = (long)(Int64)reader.Value;
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            writer.WritePropertyName("type");
            writer.WriteValue(type.ToString());
            writer.WritePropertyName("objId");
            writer.WriteValue(objId);
            writer.WritePropertyName("args");
            writer.WriteValue(args.ToBase64());
            writer.WritePropertyName("time");
            writer.WriteValue(time);
        }
    }
}
#endif
