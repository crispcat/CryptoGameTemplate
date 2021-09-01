using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class GameData : IUpdatableFrom<Game.GameData>, IHashable, ICompareChechable<Game.GameData>, IJsonSerializable
    {
        public virtual void UpdateFrom(Game.GameData other) 
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
        public virtual void CompareCheck(Game.GameData other, Stack<string> __path) 
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
