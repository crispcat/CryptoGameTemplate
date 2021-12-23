using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace CGT {

    public partial class GameData : IUpdatableFrom<GameData>, IHashable, ICompareChechable<GameData>, IJsonSerializable
    {
        public virtual void UpdateFrom(GameData other) 
        {

        }
        public virtual void Deserialize(BinaryReader reader) 
        {

        }
        public virtual void Serialize(BinaryWriter writer) 
        {

        }
        public virtual ulong CalculateHash() 
        {
            System.UInt64 hash = 345093625;
            hash += (ulong)1178352740;
            hash += hash << 11; hash ^= hash >> 7;
            return hash;
        }
        public  GameData() 
        {

        }
        public virtual void CompareCheck(GameData other, Stack<string> __path) 
        {

        }
        public virtual void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            switch(__name)
            {
            }
        }
        public virtual void WriteJsonFields(JsonTextWriter writer) 
        {

        }
    }
}
#endif
