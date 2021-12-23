using System.IO;

namespace CGT 
{
    // TODO restore build index automatization
    public class BuildIndexManager
    {
//         public const string BuildIndFileName = Resources.BuildIndFileName;//"BuildInd";
         public static int BuildInd {
             get
             {
                 //if (int.TryParse(Resources.LoadBuildIndAssetFromServer(), out var ind)) return ind;
                 return 1;
             }
         }
//
// #if !SERVER_ONLY && UNITY_EDITOR
//         public const string BuildIndFilePath = "Assets/PortalHunter/Versioning/Resources/" + BuildIndFileName + ".txt";
//         public static void IncBuildInd()
//         {
//             int ind = BuildInd;
//             if (ind == -1)
//                 ind = 1;
//             else
//                 ind++;
//             SetBuildInd(ind);
//         }
//         private static void SetBuildInd(int ind)
//         {
//             var path = Application.dataPath.Replace("/Assets", "/") + BuildIndFilePath;
//             var folder = Path.GetDirectoryName(path);
//             Directory.CreateDirectory(folder);
//             File.WriteAllText(path, ind.ToString());
//             UnityEditor.AssetDatabase.SaveAssets();
//             UnityEditor.AssetDatabase.Refresh();
//
//             UnityEditor.PlayerSettings.bundleVersion = VersionManager.CurrBuildVersion;
//             UnityEditor.PlayerSettings.iOS.buildNumber = ind.ToString();
//             UnityEditor.PlayerSettings.Android.bundleVersionCode = ind;
//         }
// #endif
    }
}