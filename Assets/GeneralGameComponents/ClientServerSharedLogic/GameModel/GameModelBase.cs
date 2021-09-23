using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZergRush.Alive;
using ZergRush.CodeGen;

namespace Game
{
    [GenTask(GenTaskFlags.LifeSupport | GenTaskFlags.DefaultConstructor | GenTaskFlags.OwnershipHierarchy |
             GenTaskFlags.UpdateFrom | GenTaskFlags.CompareChech | GenTaskFlags.Hash), GenModelRootSetup, GenCommands]
    public partial class GameModel : CommandSupportModel, ISerializable
    {
        public string displayName;
        
        public LocalMetaCommandResult ExecuteCommand(LocalMetaCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}