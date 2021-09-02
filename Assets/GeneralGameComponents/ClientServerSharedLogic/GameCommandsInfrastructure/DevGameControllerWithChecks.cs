using System.Collections.Generic;
using UnityEngine;
using ZergRush.CodeGen;

namespace Game
{
    public class DevGameControllerWithChecks : DevGameController
    {
        [GenIgnore] GameModel test;

        public override void BeforeExecutionLocalCommand(LocalMetaCommand command)
        {
            base.BeforeExecutionLocalCommand(command);
            
            // Testing commands for now
            if (test == null)
            {
                var currModel = game.SaveToBinary();
                test = currModel.LoadFromBinary<GameModel>();
                game.CompareCheck(test, new Stack<string>());
            }

            var hashBeforeBefore = game.CalculateHash();
            var hashTestBefore = test.CalculateHash();
            if (hashBeforeBefore != hashTestBefore)
            {
                Debug.LogError($"before the command hashes are no equal, possible serialization problem or unauthorized model changes, comparison:");
                game.CompareCheck(test, new Stack<string>());
                Debug.LogError($"comparison ended");
            }
        }

        void TestBinarySerialization(GameModel smth)
        {
            var bytes = smth.SaveToBinary();
            bytes.LoadFromBinary<GameModel>().CompareCheck(smth, new Stack<string>());
        }

        void RefreshTest()
        {
            var currHash = game.CalculateHash();
            var currModel = game.SaveToBinary();
            test = currModel.LoadFromBinary<GameModel>();
            var testHash = test.CalculateHash();

            if (currHash != testHash)
            {
                Debug.LogError($"hashes are not equal during model copy throw serialization, difference:");
                game.CompareCheck(test, new Stack<string>());
                Debug.LogError($"comparison end");
            }
        }

        public override void SinkLocalCommand(LocalMetaCommand command)
        {
            base.SinkLocalCommand(command);

            test.time.currTime = game.time.currTime;
            var result = test.ExecuteCommand(command);

            if (result.type != LocalMetaCommandResultType.Complete)
            {
                Debug.LogError("command failed: " + result.type);
                RefreshTest();
                return;
            }
            
            var hashBeforeAfter = game.CalculateHash();
            var hashTestAfter = test.CalculateHash();

            if (hashBeforeAfter != hashTestAfter)
            {
                Debug.LogError($"{command.type} determinism test failed, comparison:");
                game.CompareCheck(test, new Stack<string>());
                Debug.LogError($"{command.type} comparison ended");
                RefreshTest();
            }
            else
            {
                Debug.Log($"{command.type} determinism test success");
            }
            
            TestBinarySerialization(game);
        }
    }
}