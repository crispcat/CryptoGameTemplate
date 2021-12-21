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
        
        public const string DefaultSessionId = "NoSession";
        public const float MetaSessionTimeoutSeconds = 2f * 60;//5 * 60;


        public string Log(object o)
        {
            throw new NotImplementedException();
        }
    }
}