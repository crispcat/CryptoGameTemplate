#if UNITY_EDITOR
using System.Threading.Tasks;
using Game;
using UnityEditor;
using UnityEngine;

namespace GameTemplate
{
    public class ConfigManagementWindow // : EditorContentTab
    {
        public string TabName => "Configs";

        bool detailsToggle
        {
            get => PlayerPrefs.GetInt("AssetBundleController_detailsToggle") == 0;
            set => PlayerPrefs.SetInt("AssetBundleController_detailsToggle", value ? 0 : 1);
        }
        int _versionStatusOptionInd;

        string[] versionStatusOptionsCaption = new string[] { "Dont change version status", "Up to date", "Set can be updated", "Set must be updated" };

        static VersionStatus[] versionStatusOptions = new VersionStatus[] { VersionStatus.NotDefined, VersionStatus.UpToDate, VersionStatus.CanBeUpdated, VersionStatus.MustBeUpdated };

        bool _updatesAssetBundlesHash = false;

        public void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            {
                if (GUILayout.Button("Generate local config"))
                    GenerateLocalConfig();

                if (GUILayout.Button("Download config data"))
                    LoadConfigsSource();

                // if (GUILayout.Button($"Upload configs to server v{VersionManager.CurrBuildVersion}"))
                //     UploadConfig();
                //
                // if (GUILayout.Button($"Upload store config to PlayFab"))
                //     UploadStore();
                //
                // EditorGUILayout.BeginHorizontal();
                // if (GUILayout.Button($"Update master config v{VersionManager.CurrBuildVersion}"))
                //     UpdateMasterConfig(_updatesAssetBundlesHash, _versionStatusOptionInd);
                // detailsToggle = GUILayout.Toggle(detailsToggle, "details...", GUILayout.Width(100));
                // EditorGUILayout.EndHorizontal();

                if (detailsToggle)
                {
                    EditorGUILayout.BeginHorizontal();
                    _versionStatusOptionInd = GUILayout.Toolbar(_versionStatusOptionInd, versionStatusOptionsCaption);
                    EditorGUILayout.EndHorizontal();

                    EditorGUILayout.BeginHorizontal();
                    _updatesAssetBundlesHash = GUILayout.Toggle(_updatesAssetBundlesHash, "update bundles hashes");
                    EditorGUILayout.EndHorizontal();
                }
            }
            EditorGUILayout.EndVertical();
        }

        public static void GenerateLocalConfig()
        {
            ConfigsBuilder.GenerateAndSaveConfig(ConfigsLoader.ConfigsPathEditorDebug);
        }

        public static async Task LoadConfigsSource()
        {
            ConfigsBuilder.LoadConfigsSource(); // todo make async?
        }

        public static async Task UploadStore()
        {
#if ADMIN && ENABLE_PLAYFABADMIN_API
            PlayFabDataUploader.UpdatePlayFabData();
#endif
        }

        public static async Task UploadConfig()
        {
            await ConfigsLoader.StartUploading();
        }

        // public static async Task UpdateMasterConfig(bool updatesAssetBundlesHash, int status)
        // {
        //     ulong? iosBundles = null;
        //     ulong? androidBundles = null;
        //     ulong? windowsBundles = null;
        //     if (updatesAssetBundlesHash)
        //     {
        //         var android = await AssetBundleService.DownloadManifest(PlatformKey.Android);
        //         if (android != null) androidBundles = android.CalculateHash();
        //         var ios = await AssetBundleService.DownloadManifest(PlatformKey.iOS);
        //         if (ios != null) iosBundles = ios.CalculateHash();
        //         var windows = await AssetBundleService.DownloadManifest(PlatformKey.StandaloneWindows);
        //         if (windows != null) windowsBundles = windows.CalculateHash();
        //     }
        //
        //     ConfigsLoader.LoadConfigLocal();
        //
        //     await MasterConfig.UpdateMasterConfig(
        //         status: versionStatusOptions[status],
        //         windowsBundles: windowsBundles,
        //         androidBundles: androidBundles,
        //         iosBundles: iosBundles,
        //         cachedConfig: GameConfig.Instance.CalculateHash()
        //     );
        // }
    }
}
#endif