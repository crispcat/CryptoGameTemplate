using UnityEngine;
using ZergRush.CodeGen;

namespace ClientServerSharedLogic
{
    // Test dto struct
    
    [GenInLocalFolder, GenTask(GenTaskFlags.JsonSerialization | GenTaskFlags.Hash)]
    public partial struct PlayerPositionData
    {
        public Vector3 pos;
        
        public PlayerPositionData(float x, float y, float z)
        {
            pos.x = x;
            pos.y = y;
            pos.z = z;
        }

        public PlayerPositionData(Vector3 pos)
        {
            this.pos = pos;
        }

        public override string ToString()
        {
            return pos.ToString();
        }
    }
}