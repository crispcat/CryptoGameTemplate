#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace PlayFabServerTool
{
    public class PfServerTool_Window : EditorWindow
    {
        [MenuItem("PfServerTool/ControlPanel")]
        private static void Launch()
        {
            var window = GetWindow<PfServerTool_Window>();
            window.minSize = new Vector2(300, 300);
            window.Show();
        }

        private static string allocateServerBuildId;
        private static string allocateServerRegion = "EastUS";

        private static string killServerSessionId;

        private static string debuggerIp;
        private static string debuggerPort;

        private void OnEnable()
        {
            PfServerTool.ServersStateUpdated += Repaint;
        }

        private void OnDisable()
        {
            PfServerTool.ServersStateUpdated -= Repaint;
        }

        private void OnGUI()
        {
            GUILayout.Label("Servers state:");
            GUILayout.Space(10);
            
            if (GUILayout.Button("Update"))
                PfServerTool.UpdateServersState();
            
            GUILayout.TextArea(PfServerTool.serversState);

            GUILayout.Space(10);
            GUILayout.Label("Allocate server session:");
            GUILayout.BeginHorizontal();
            GUILayout.Label("BuidID:");
            allocateServerBuildId = EditorGUILayout.TextField(allocateServerBuildId);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Region:");
            allocateServerRegion = EditorGUILayout.TextField(allocateServerRegion);
            GUILayout.EndHorizontal();
            if (GUILayout.Button("Allocate"))
                PfServerTool.AllocateServerSession(allocateServerBuildId, allocateServerRegion);
            
            GUILayout.Space(10);
            GUILayout.Label("Debbuger:");
            GUILayout.BeginHorizontal();
            GUILayout.Label("IP:");
            debuggerIp = EditorGUILayout.TextField(debuggerIp);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Port:");
            debuggerPort = EditorGUILayout.TextField(debuggerPort);
            GUILayout.EndHorizontal();
            if (GUILayout.Button("Connect"))
                PfServerDebugger.Connect(debuggerIp, int.Parse(debuggerPort));
            if (GUILayout.Button("Disconnect"))
                PfServerDebugger.Disconnect();
            
            // GUILayout.Space(10);
            // GUILayout.Label("Kill server session:");
            // GUILayout.BeginHorizontal();
            // GUILayout.Label("SessionID:");
            // killServerSessionId = EditorGUILayout.TextField(killServerSessionId);
            // GUILayout.EndHorizontal();
            // if (GUILayout.Button("Kill"))
            //     PfServerTool.KillServerSession(killServerSessionId);
        }
    }
}
#endif