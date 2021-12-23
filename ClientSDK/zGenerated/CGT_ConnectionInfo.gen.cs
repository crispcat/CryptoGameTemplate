using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace CGT {

    public partial class ConnectionInfo : IHashable
    {
        public virtual void Deserialize(BinaryReader reader) 
        {
            ip0 = reader.ReadByte();
            ip1 = reader.ReadByte();
            ip2 = reader.ReadByte();
            ip3 = reader.ReadByte();
            port = reader.ReadInt32();
        }
        public virtual void Serialize(BinaryWriter writer) 
        {
            writer.Write(ip0);
            writer.Write(ip1);
            writer.Write(ip2);
            writer.Write(ip3);
            writer.Write(port);
        }
        public virtual ulong CalculateHash() 
        {
            System.UInt64 hash = 345093625;
            hash += (ulong)1790635586;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (System.UInt64)ip0;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (System.UInt64)ip1;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (System.UInt64)ip2;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (System.UInt64)ip3;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (System.UInt64)port;
            hash += hash << 11; hash ^= hash >> 7;
            return hash;
        }
    }
}
#endif
