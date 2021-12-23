using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;
using ZergRush.CodeGen;

namespace CGT
{
    [GenTask(GenTaskFlags.ConfigData)]
    public partial class GameConfig : ISerializable, IJsonSerializable
    {
        public static string SaveDir = "Assets/Game/Resources/";
        public static string ClientEditorPathJson = SaveDir + "config.json";
        public static string ClientEditorPathBinary = SaveDir + "config.txt";

        public static GameConfig Instance { get; set; }

        public static void SetGameConfig(Action<GameConfig> fillInstance)
        {
            Instance = new GameConfig();
            fillInstance(Instance);
            Debug.Log($"Game config loaded");
        }

        public static async Task SetGameConfig(Func<GameConfig, Task> fillInstance)
        {
            Instance = new GameConfig();
            await fillInstance(Instance);
            Debug.Log($"Game config loaded");
        }
    }
}
