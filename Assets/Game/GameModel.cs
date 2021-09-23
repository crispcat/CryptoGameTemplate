using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public partial class GameModel 
    {
        public static GameModel Default()
        {
            return new GameModel();
        }

        [LocalCommand]
        void TestCommand()
        {
            
        }
    }
}