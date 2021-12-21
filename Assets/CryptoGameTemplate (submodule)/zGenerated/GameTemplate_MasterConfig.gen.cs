using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace GameTemplate {

    public partial class MasterConfig : IJsonSerializable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            status = reader.ReadEnum<GameTemplate.VersionStatus>();
            configHash = reader.ReadUInt64();
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            writer.Write((Int32)status);
            writer.Write(configHash);
        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
                case "status":
                status = ((string)reader.Value).ParseEnum<GameTemplate.VersionStatus>();
                break;
                case "configHash":
                configHash = ulong.Parse((string)reader.Value);
                break;
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {
            writer.WritePropertyName("status");
            writer.WriteValue(status.ToString());
            writer.WritePropertyName("configHash");
            writer.WriteValue(configHash.ToString());
        }
    }
}
#endif
