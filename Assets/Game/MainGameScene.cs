using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class MainGameScene : MonoBehaviour
    {
        public Button testGoodCommand;
        public Button testBadCommand;
        
        public void Start()
        {
            testGoodCommand.Subscribe(() => GameSession.game.TestCommandCommand());
            testBadCommand.Subscribe(() => GameSession.game.UnAutherizedStateChange());
        }
    }
}