using System;
using System.IO;
using ZergRush.CodeGen;

namespace Game
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization)]
    public partial class RemoteMetaRequest : ISerializable
    {
        public LocalCommandsBatch localCommandsBatch = new LocalCommandsBatch();
        public RemoteMetaRequestType type;
        public long time;
        [CanBeNull] public byte[] args;
        [CanBeNull] public string sessionId;

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}