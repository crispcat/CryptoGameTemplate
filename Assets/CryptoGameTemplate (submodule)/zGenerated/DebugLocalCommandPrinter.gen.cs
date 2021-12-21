using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public static partial class DebugLocalCommandPrinter
    {
        public static string PrintArgs(LocalMetaCommandType __type, byte[] __data, GameModel root) 
        {
            if (__data == null) return "";
            var reader = new BinaryReader(new MemoryStream(__data));
            switch (__type)
            {
                case LocalMetaCommandType.TestCommand:
                {
                    return $"";
                }
            }
            return "invalid command type";
        }
    }
}
#endif
