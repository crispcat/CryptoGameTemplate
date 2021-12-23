using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZergRush.CodeGen;

namespace CGT
{
    [GenTask(GenTaskFlags.Serialization | GenTaskFlags.JsonSerialization)]
    public partial class MasterConfig : ISerializable, IJsonSerializable
    {
        public VersionStatus status;
        public ulong configHash;
        public static MasterConfig instance { get; private set; }
    }

    public enum VersionStatus
    {
        NotDefined,
        UpToDate,
        CanBeUpdated,
        MustBeUpdated
    }
}