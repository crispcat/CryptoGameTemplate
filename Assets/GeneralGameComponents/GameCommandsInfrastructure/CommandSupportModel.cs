using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZergRush.Alive;
using ZergRush.CodeGen;

namespace Game
{
    public partial class CommandSupportModel : LivableRoot
    {
        [GenIgnore] public IGameCommandSink controllerBase;

        public void BeforeExecutionLocalCommand(LocalMetaCommand command)
        {
            controllerBase.BeforeExecutionLocalCommand(command);
        }
        public void SinkLocalCommand(LocalMetaCommand command)
        {
            controllerBase.SinkLocalCommand(command);
        }
        public void ExecutionFailed(LocalMetaCommand command)
        {
            controllerBase.CommandExecutionFailed(command);
        }

        [GenIgnore] public GameTime time = new GameTime();
        public LocalMetaCommand PrepareCommand(LocalMetaCommandType type, int id)
        {
            return new LocalMetaCommand{type = type, objId = id, time = time};
        }
        
        public new CommandSupportModel root
        {
            get { return (CommandSupportModel) base.root; }
            set { base.root = value; }
        }
    }
}
