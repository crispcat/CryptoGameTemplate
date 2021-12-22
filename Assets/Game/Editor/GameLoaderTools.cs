using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Game
{
    public static class GameLoaderTools
    {
        [MenuItem("GameTools/Play #&d")]
        public static async void PlayFromPrelaunchScene()
        {
            if (EditorApplication.isPlaying == true)
            {
                EditorApplication.isPlaying = false;
                return;
            }

            var scenePath = EditorSceneManager.GetActiveScene().path;
            Debug.Log($"active scene {scenePath}");
            EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene());
            EditorSceneManager.OpenScene("Assets/Game/LoaderScene.unity");
            EditorApplication.isPlaying = true;

            await Task.Delay(500);
            while (EditorApplication.isPlaying) await Task.Yield();

            Debug.Log($"return to scene {scenePath}");
            EditorSceneManager.OpenScene(scenePath);
        }
    }
}