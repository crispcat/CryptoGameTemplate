using System.Collections;
using System.Collections.Generic;
using Game;
using GameTools;
using UnityEngine;

namespace Game
{
// Basic config loader and parser from public google tables
    public static partial class ConfigsBuilder
    {
        static SpreadsheetLoader _loader;

        static SpreadsheetLoader loader =>
            _loader ??= new SpreadsheetLoader("Assets/ConfigsSource/", googleConfig, new AtlassianSheetConfig());

        static CsvReader Page(GooglePages pageName)
        {
            return loader.Page(pageName);
        }

        public static void GenerateAndSaveConfig(string configsPath)
        {
            var config = new GameConfig();
            ParseConfig(config);
            config.SaveToJsonFile(configsPath);
        }

        public static void LoadConfigsSource()
        {
            loader.DownloadAllConfigs();
        }
    }
}