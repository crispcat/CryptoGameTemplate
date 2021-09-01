using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZergRush.Alive;
using ZergRush.CodeGen;

namespace Game
{
    [GenTask(GenTaskFlags.LifeSupport | GenTaskFlags.DefaultConstructor | GenTaskFlags.OwnershipHierarchy |
             GenTaskFlags.UpdateFrom | GenTaskFlags.CompareChech | GenTaskFlags.Hash), GenModelRootSetup]
    public partial class GameModel : CommandSupportModel
    {
    }
}