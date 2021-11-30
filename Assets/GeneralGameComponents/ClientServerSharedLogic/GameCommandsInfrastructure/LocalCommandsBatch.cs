using System;
using System.IO;
using ZergRush.CodeGen;
using ZergRush.ReactiveCore;

namespace Game
{
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization)]
    public partial class LocalCommandsBatch : ISerializable
    {
        public ReactiveCollection<LocalMetaCommand> items = new ReactiveCollection<LocalMetaCommand>();
    }
}