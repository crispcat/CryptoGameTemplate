using System;
using System.IO;
using ZergRush.CodeGen;
using ZergRush.ReactiveCore;

namespace CGT
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization), GenInLocalFolder]
    public partial class LocalCommandsBatch : ISerializable
    {
        public ReactiveCollection<LocalMetaCommand> items = new ReactiveCollection<LocalMetaCommand>();
    }
}