using System;
using System.Threading.Tasks;
using CGT;
using UnityEngine;
using ZergRush;

namespace CGT
{
    public static class ConfigsLoader
    {
        public static string ConfigsPathEditorDebug => "config.json";
        public static string ConfigsPathCache => "configCache";
        public static string ConfigsPathOnCDN => $"{VersionManager.CurrBuildVersion}/config";

#if UNITY_EDITOR
        public static bool loadLocal
        {
            get => PlayerPrefs.GetInt("load_local", 0) != 0;
            set
            {
                PlayerPrefs.SetInt("load_local", value ? 1 : 0);
                PlayerPrefs.Save();
            }
        }

        public static async Task StartUploading()
        {
            LoadConfigLocal();
            // Upload config to server storage
            throw new NotImplementedException();
        }

        public static void LoadConfigLocal()
        {
            GameConfig.SetGameConfig(config =>
            {
                SerializationTools.ReadFromJsonFile(ConfigsPathEditorDebug, config);
            });
        }

        public static void CheckLocalConfig()
        {
            if (GameConfig.Instance == null) LoadConfigLocal();
        }
#endif

        public static bool CanLoadFromCache()
        {
            return FileWrapper.Exists(ConfigsPathCache);
        }

        public static void LoadFromCache()
        {
#if UNITY_EDITOR
            if (loadLocal)
            {
                LoadConfigLocal();
                return;
            }
#endif
            GameConfig.SetGameConfig(config => SerializationTools.ReadFromFile(ConfigsPathCache, true, config));
        }

        public static async Task<bool> LoadConfig()
        {
#if UNITY_EDITOR
            if (loadLocal)
            {
                LoadConfigLocal();
                return true;
            }
#endif

            string path = ConfigsPathCache;
            Func<GameConfig, Task> fillConfig = async (config) =>
            {
                try
                {
                    config = FileWrapper.Exists(path) ? SerializationTools.ReadFromFile(path, true, config) : null;
                }
                catch (Exception e)
                {
                    config = null;
                    Debug.Log($"cant load config from file from cache path:{path}\nerror:{e.ToError()}");
                }

                bool downloadConfig = config == null;
                if (config != null)
                {
                    ulong loadedConfigHash = config.CalculateHash();
                    ulong latestConfigHash = MasterConfig.instance.configHash;

                    if (loadedConfigHash != latestConfigHash)
                    {
                        Debug.Log($"config redownloading: cached = {loadedConfigHash}, latest = {latestConfigHash}");
                        downloadConfig = true;
                    }
                    else
                    {
                        Debug.Log($"use local cached config with hash: {loadedConfigHash}");
                    }
                }

                // if (downloadConfig)
                // {
                //     var data = await BaseCDNController.Instance.DownloadFileAsync(ConfigsPathOnCDN);
                //     Action<GameConfig> fill = conf => SerializationTools.DeserializeFromBytes(data, conf);
                //     GameConfig.SetGameConfig(fill);
                //     data.SaveToFilePure(ConfigsPathCache, true);
                // }
            };
            await GameConfig.SetGameConfig(fillConfig);
            return true;
        }
    }
}