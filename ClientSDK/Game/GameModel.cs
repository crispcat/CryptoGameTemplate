using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CGT
{
    public partial class GameModel
    {
        public int state;
        
        public static GameModel Default()
        {
            return new GameModel();
        }

        [LocalCommand]
        void TestCommand()
        {
            state++;
        }

        public void UnAutherizedStateChange()
        {
            state += 100;
        }
    }
}