using System;
using System.Collections.Generic;
using System.Reflection;
using PlayFab;
using UnityEditor;
using ZergRush;
using ZergRush.CodeGen;

public static partial class PlayFabSyncWrapperGen
{
    public const string PLAYFABLESS_DEFINE = "PLAYFABLESS";

    [MenuItem("Code Gen/Gen PlayFab Async Api")]
    public static void GeneratePlayFabAPIAsyncWrappers()
    {
#if !RELEASE
        GeneratePlayFabAPIAsyncWrapper(typeof(PlayFabServerAPI), null /*typeof(PlayFablessServerAPI)*/, "ENABLE_PLAYFABSERVER_API", new[] { "PlayFab.ServerModels" });
        GeneratePlayFabAPIAsyncWrapper(typeof(PlayFabClientAPI), null /*typeof(PlayFablessClientAPI)*/, "!DISABLE_PLAYFABCLIENT_API", new[] { "PlayFab.ClientModels" }, true);
        GeneratePlayFabAPIAsyncWrapper(typeof(PlayFabAdminAPI), null /*typeof(PlayFablessAdminAPI)*/, "ENABLE_PLAYFABADMIN_API", new[] { "PlayFab.AdminModels" }, true);
        GeneratePlayFabAPIAsyncWrapper(typeof(PlayFabMatchmakerAPI), null, "ENABLE_PLAYFABSERVER_API", new[] { "PlayFab.MatchmakerModels" });
#endif
    }
    private static List<string> allowedMethodsInPlayfabless = new List<string>()
    {
        "ListServerBuildsAsync",
        "RemoveServerBuildAsync",
        "GetServerBuildUploadUrlAsync",
        "AddServerBuildAsync",
        "GetServerBuildInfoAsync",
        "ModifyServerBuildAsync",
        "GetContentUploadUrlAsync",
        "GetContentDownloadUrlAsync"
    };
    public static void GeneratePlayFabAPIAsyncWrapper(Type playfabAPIClassType, Type playfablessAPIClassType,
        string directive, string[] usings, bool executesInEditMode = false)
    {
        var generatePlayfabless = playfablessAPIClassType != null;            

        var context = new GeneratorContext(new GenInfo { sharpGenPath = "Assets/GeneralGameComponents/PlayfabAsyncWrapper" }, false);
        var module = context.createSharpCustomModule($"{playfabAPIClassType.Name}AsyncWrapper");
        module.content($"#if {directive}");
        usings.ForEach(s => module.content($"using {s};"));
        module.content($"#endif");

        var moduleName = playfabAPIClassType.Name + "Async";
        
        var sink = module.Class(moduleName, "PlayFab", false, false, true, true);
        sink.usingSink("System.Threading.Tasks");
        sink.content($"#if {directive}");
        sink.content($"public static Timing lastCallTiming {{ get; private set; }}");
        var getMethodsFlags = BindingFlags.Public | BindingFlags.Static;
        var funcs = playfabAPIClassType.GetMethods(getMethodsFlags);
        var playfablessFuncs = generatePlayfabless ? playfablessAPIClassType.GetMethods(getMethodsFlags) : null;
        foreach (var func in funcs)
        {
            if (func.GetParameters().Length != 5) continue;
            if (func.IsGenericMethod) continue;
            var asyncFuncName = $"{func.Name}";
            var playfablessFunc = playfablessFuncs?.Find(currFunc => currFunc.Name == asyncFuncName);
            // get respone type from action callback
            var responseType = func.GetParameters()[1].ParameterType.FirstGenericArg();
            var responseTypeName = responseType.RealName();
            sink.content($"public static async Task<PlayFabResult<{responseTypeName}>> " +
                         $"{asyncFuncName}({func.GetParameters()[0].ParameterType.RealName()} request)");
            sink.openBrace();
            sink.content($"var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);");
            sink.content($"PlayFabResult<{responseTypeName}> waiter;");
            void SinkCallRealPlayfab()
            {
                sink.content($"waiter = new PlayFabResult<{responseTypeName}>();");
                sink.content($"{playfabAPIClassType.Name}.{func.Name}(request, waiter.processSuccess, waiter.processFail);");
                if (executesInEditMode)
                    sink.content($"while (waiter.keepWaiting) await Task.Delay(10);");
                else
                    sink.content($"await waiter;");
            }
            if (!generatePlayfabless)
            {
                SinkCallRealPlayfab();
            }
            else
            {
                if (!allowedMethodsInPlayfabless.Contains(asyncFuncName))
                    sink.content("#if !PLAYFABLESS");
                else
                    sink.content("#if true");
                SinkCallRealPlayfab();
                sink.content("#else");
                if (playfablessFunc == null)
                {
                    // Make calling playfab method throw exception if playfabless implementation does not have such method.
                    sink.content($"throw new PortalHunter.RiftersException(\"" +
                                 $"method {playfablessAPIClassType.Name}.{asyncFuncName} does not exist\");");
                }
                else
                {
                    // Call playfabless implementation.
                    if (playfabAPIClassType == typeof(PlayFabServerAPI))
                        sink.content($"PortalHunter.Tools.LoadTests.MetaServerLoadTracking.OnServerAPICall();");
                    sink.content($"waiter = await {playfablessAPIClassType.Name}.{asyncFuncName}(request);");
                }
                sink.content("#endif");
            }
            sink.content($"lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);");
            sink.content($"return waiter;");
            sink.closeBrace();
        }
        sink.content($"#endif");

        context.Commit();
        AssetDatabase.Refresh();
    }
}