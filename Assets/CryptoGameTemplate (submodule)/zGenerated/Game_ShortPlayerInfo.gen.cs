using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial struct ShortPlayerInfo
    {
        public void Deserialize(BinaryReader reader) 
        {
            if (!reader.ReadBoolean()) {
                displayName = null;
            }
            else { 
                displayName = reader.ReadString();
            }
            level = reader.ReadInt32();
        }
        public void Serialize(BinaryWriter writer) 
        {
            if (displayName == null) writer.Write(false);
            else {
                writer.Write(true);
                writer.Write(displayName);
            }
            writer.Write(level);
        }
    }
}
#endif
