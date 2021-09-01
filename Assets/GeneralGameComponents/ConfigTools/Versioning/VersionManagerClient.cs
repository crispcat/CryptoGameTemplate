#if CLIENT
using PortalHunter.GameMeta.View;
using PortalHunter.GameRoot;
using PortalHunter.GameTools.AssetBundles;
using PortalHunter.Tools;
using System.Threading.Tasks;
using UnityEngine.Advertisements;

namespace GameTemplate 
{
    public partial class VersionManager
    {
        static VersionManager _instance;
        public static VersionManager instance => _instance ?? (_instance = new VersionManager());
        public static VersionStatus clientVersionStatus => MasterConfig.instance.status;

        public static async Task EnsureEverythingUpToDate(bool asRelease) // client, config, bundles etc.
        {
            Utils.ForbidScreenSleep();

            await PlayfabAuth.EnsureCanMakeRequests();

            var masterConfigOk = await MasterConfig.Download(true);
            if (!masterConfigOk)
                throw new RiftersNoInternetConnection($"master config for version {CurrBuildVersion} was not loaded");

            // Client have to be up to date.
            if (clientVersionStatus != VersionStatus.UpToDate)
                await WindowManager.instance.ShowModal<UpdateWindow>(w => w.Show(clientVersionStatus == VersionStatus.CanBeUpdated));

            await AssetBundleService.EnsureAssetbundlesForStartGameLoaded();

            // GameConfig have to be up to date.
            if (asRelease)
                await ConfigsLoader.LoadInReleaseClient();
            else
                await ConfigsLoader.LoadInDebugClient();
            GameClientRoot.Instance.ReportGameProgress(new GameConfigLoaded());

            await EulaWindow.EnsureAccepted();
            
            if (Advertisement.isSupported && !Advertisement.isInitialized)
            {
                var testMode = true;
                #if RELEASE
                testMode = false;
                #endif
                Advertisement.Initialize("3117979", testMode);
            }

            Utils.AllowScreenSleep();
        }
    }
}
#endif