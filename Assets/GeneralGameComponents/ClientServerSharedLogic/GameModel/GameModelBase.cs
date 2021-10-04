using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZergRush.CodeGen;

namespace Game
{
    [GenTask(GenTaskFlags.LifeSupport | GenTaskFlags.DefaultConstructor | GenTaskFlags.OwnershipHierarchy |
             GenTaskFlags.UpdateFrom | GenTaskFlags.CompareChech | GenTaskFlags.Hash), GenModelRootSetup, GenCommands]
    public partial class GameModel : CommandSupportModel, ISerializable, ILocalCommandExecuter
    {
        public string displayName;
    }
}