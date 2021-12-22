using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using ZergRush;

namespace GameTemplate
{
    /*
     *     TODO
     *     In this file will be all config management stuff
     *     Need to think best modern way to do it
     */
    public partial class MasterConfig : IJsonSerializable
    {
        static string masterConfigCDNPath = $"{VersionManager.CurrBuildVersion}/masterConfig";
        
        public enum PlatformKey
        {
            Android,
            iOS,
            StandaloneWindows
        }

        public static async Task<bool> Download(bool log = false)
        {
            throw new NotImplementedException();

            // TODO what way we use to get the config
            byte[] bytes = null; //await BaseCDNController.Instance.DownloadFileAsync(masterConfigCDNPath, true);
            if (bytes == null)
                return false;
            try
            {
                var config = SerializationTools.DeserializeFromBytes<MasterConfig>(bytes);
                instance = config ?? throw new ZergRushException("cant deserialize master config");
                if (log)
                    Debug.Log($"downloaded master config = {config.SaveToJsonString()}");
                return true;
            }
            catch (Exception e)
            {
                Debug.Log($"master config deserialization exception {e.ToError()}");
                return false;
            }
        }

        public static void SetForEditorTools()
        {
            instance = new MasterConfig
            {
                status = VersionStatus.UpToDate
            };
        }

#if UNITY_EDITOR

        public static async Task UpdateMasterConfig(ulong? cachedConfig = null, VersionStatus status = VersionStatus.NotDefined)
        {
            await UpdateMasterConfig(config =>
            {
                if (cachedConfig.HasValue)
                    config.configHash = cachedConfig.Value;
                if (status != VersionStatus.NotDefined)
                    config.status = status;
            });
        }

        public static async Task UpdateMasterConfig(Action<MasterConfig> updateConfig)
        {
            // UnityEditor.EditorUtility.DisplayProgressBar("Updating master config", "downloading existing...", 0);
            // bool downloaded = await Download();
            // //bool downloaded = false; //await Download();
            // if (!downloaded)
            //     instance = MasterConfig.CreateForNewVersion();
            // UnityEditor.EditorUtility.DisplayProgressBar("Updating master config", "uploading updated one...", 0);
            // updateConfig(instance);
            // await UploadConfig();
            // UnityEditor.EditorUtility.ClearProgressBar();
        }

        private static async Task UploadConfig()
        {
            // var bytes = instance.SerializeToBytes();
            // await BaseCDNController.Instance.UploadFileAsync(masterConfigCDNPath, bytes);
            // Debug.Log($"uploaded master config = {instance.SaveToJsonString()}");
        }
#endif
    }
}