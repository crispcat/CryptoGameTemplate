using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace ClientServerSharedLogic {

    public partial struct PlayerPositionData : IHashable
    {
        public ulong CalculateHash() 
        {
            System.UInt64 hash = 345093625;
            hash += (ulong)983686600;
            hash += hash << 11; hash ^= hash >> 7;
            hash += pos.CalculateHash();
            hash += hash << 11; hash ^= hash >> 7;
            return hash;
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
                        case "pos":
                        pos = (UnityEngine.Vector3)reader.ReadFromJsonUnityEngine_Vector3();
                        break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) { break; }
            }
        }
        public void WriteJson(JsonTextWriter writer) 
        {
            writer.WriteStartObject();
            writer.WritePropertyName("pos");
            pos.WriteJson(writer);
            writer.WriteEndObject();
        }
    }
}
#endif
