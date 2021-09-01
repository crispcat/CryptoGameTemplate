
namespace GameTemplate 
{
    public class BuildInfo
    {
#if SERVER
        public static string GetServer() => Get(true, GameServerRoot.type.ToString());
#endif
        //public static string GetClient() => Get(false, Debug.isDebugBuild ? "debug" : "release");
        private static string Get(bool isServerBuild, string type) {
            string buildServerness = isServerBuild ? "server" : "client";
            var buildInfo = $"v{VersionManager.CurrBuildVersionWithIndex} {type} {buildServerness} build";            
            return buildInfo;
        }
    }

    public enum ServerBuildType
    {
        debug,
        release,
        loadTests,
        loadTestsWithProfiler
    }
}