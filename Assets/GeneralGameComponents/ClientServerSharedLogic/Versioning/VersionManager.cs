using GameTools;
using PortalHunter.Versioning;
using System;
using System.Threading.Tasks;

namespace GameTemplate
{
    public static partial class VersionManager
    {
        public const string CurrBuildVersion = "1.0.21";
        
        public const string CurrPlayfabCatalog = "1.0";
        public static int BuildInd => BuildIndexManager.BuildInd;
        public static string CurrBuildVersionWithIndex => $"{CurrBuildVersion}.{BuildInd}";
        public static VersionStatus clientVersionStatus => MasterConfig.instance.status;

        public static void ActivateOfflineMode() => _offlineMode = true;
        public static bool offlineMod => _offlineMode;
        static bool _offlineMode;

        // public static bool CanWorkOffline() => ConfigsLoader.CanLoadFromCache() && SimpleCache.HasCachedBundleManifest();
        // public static void OfflineLoad() // client, config, bundles etc.
        // {
        //     if (GameConfig.Instance == null)
        //         ConfigsLoader.LoadFromCache();
        //     if (AssetBundleService.AppManifest == null)
        //         AssetBundleService.SetAppManifest(SimpleCache.LoadBundlesManifest());
        // }
        //
        // public static async Task EnsureEverythingUpToDate(IProgress<float> progressReport) // client, config, bundles etc.
        // {
        //     if (_offlineMode)
        //     {
        //         progressReport.Report(1);
        //         OfflineLoad();
        //         return;
        //     }
        //
        //     var masterConfigOk = await MasterConfig.Download(true);
        //     if (!masterConfigOk) throw new RiftersNoInternetConnection($"master config for version {CurrBuildVersion} was not loaded");
        //
        //     var result = await ConfigsLoader.LoadConfig();
        //     progressReport.Report(.5f);
        //
        //     await AssetBundleService.LoadLatestManifest();
        //     progressReport.Report(1f);
        // }
    }

    public class RiftersNoInternetConnection : Exception
    {
        public RiftersNoInternetConnection(string s) : base(s)
        {
        }
    }
}