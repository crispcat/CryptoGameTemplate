using System;
using System.Threading.Tasks;
using UnityEngine;
using ZergRush.ReactiveCore;

namespace CGT
{
    public class DevGameController : IGameControllerBase, IGameCommandSink
    {
        GameModel _game;
        public GameModel game { get => _game; set => _game = value; }

        EventStream<string> fail = new EventStream<string>();
        const string fileName = "local_player_model";
        
        public DevGameController()
        {
            game = new GameModel();
            LoadPlayer();
        }

        void LoadPlayer()
        {
            if (!SerializationTools.LoadFromJsonFile(fileName, out _game))
                game = GameModel.Default();
            game.controllerBase = this;
        }

        public void OnApplicationPause()
        {
            SavePlayer();
        }

        public long metaTime => DateTime.Now.Ticks;
        public void OnUnityUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F10))
            {
                fail.Send("Test fail");
            }
        }

        public IEventStream<string> RestartNeeded()
        {
            return fail;
        }

        public async Task Exit()
        {
            SavePlayer();
        }

        void SavePlayer()
        {
            game.SaveToJsonFile(fileName);
        }

        public virtual void SinkLocalCommand(LocalMetaCommand command)
        {
        }

        public virtual void BeforeExecutionLocalCommand(LocalMetaCommand command)
        {
            Debug.Log(command);
        }

        public virtual void CommandExecutionFailed(LocalMetaCommand command)
        {
            
        }
    }
}