using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class LocalCommandsBatch : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            items.Deserialize(reader);
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            items.Serialize(writer);
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "items":
                items.ReadFromJson(reader);
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            writer.WritePropertyName("items");
            items.WriteJson(writer);
        }
    }
}
#endif
