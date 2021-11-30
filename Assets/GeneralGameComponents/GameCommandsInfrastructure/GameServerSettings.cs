using System;
using UnityEngine;

namespace Game
{
    public enum GameServerMode
    {
        Meta,
    }
    
    public enum Region
    {
        USCentral,
        USEast,
        EUWest,
        Singapore,
        Japan,
        Brazil,
        Australia
    }
    
    public static class GameServerSettings
    {
        public static string game_id { get; private set; }

        public static string LobbyId
        {
            get { return game_id; }
        }

        public static string game_build_version { get; private set; }
        public static string game_mode { get; private set; }
        public static GameServerMode gameMode { get; private set; }
        public static string server_host_domain { get; private set; }
        public static int server_host_port { get; private set; }
        public static Region server_host_region { get; private set; }
        public static string playfab_api_endpoint { get; private set; }
        public static string title_secret_key { get; private set; }
        public static string custom_data { get; private set; }
        public static string logFile { get; private set; }
        public static string output_files_directory_path { get; private set; }
        public static bool IsInCloud { get; private set; }
        public static bool IsLocalTest { get; private set; }
        private static int meta_fps = 50;
        private static int battle_fps = 30;
        private static int tournament_fps = 30;
        public static int battle_step_ms { get; private set; } = 50;
        public static bool logs_enabled { get; private set; }
        public static string host_player_id { get; private set; } = "";

        static GameServerSettings()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();
            CreateFromCommandLine(commandLineArgs);
        }

        public static void CreateFromCommandLine(string[] commandLineArgs)
        {
            foreach (var arg in commandLineArgs)
            {
                var argArray = arg.Split('=');
                if (argArray.Length < 2)
                    continue;
                var key = argArray[0].Contains("-") ? argArray[0].Replace("-", "").Trim() : argArray[0].Trim();
                var value = argArray[1].Trim();

                switch (key)
                {
                    case CmdParams.game_id:
                        game_id = value;
                        break;
                    case CmdParams.game_build_version:
                        game_build_version = value;
                        break;
                    case CmdParams.game_mode:
                        game_mode = value;
                        break;
                    case CmdParams.server_host_domain:
                        server_host_domain = value;
                        break;
                    case CmdParams.server_host_port:
                        server_host_port = int.Parse(value);
                        break;
                    case CmdParams.server_host_region:
                        server_host_region = (Region) Enum.Parse(typeof(Region), value);
                        break;
                    case CmdParams.playfab_api_endpoint:
                        playfab_api_endpoint = value;
                        break;
                    case CmdParams.title_secret_key:
                        title_secret_key = value;
                        break;
                    case CmdParams.custom_data:
                        custom_data = value;
                        break;
                    case CmdParams.logFile:
                        logFile = value;
                        break;
                    case CmdParams.output_files_directory_path:
                        output_files_directory_path = value;
                        break;
                    case CmdParams.battle_fps:
                        battle_fps = int.Parse(value);
                        break;
                    case CmdParams.meta_fps:
                        meta_fps = int.Parse(value);
                        break;
                    case CmdParams.tournament_fps:
                        tournament_fps = int.Parse(value);
                        break;
                    case CmdParams.battle_step_ms:
                        battle_step_ms = int.Parse(value);
                        break;
                    case CmdParams.host_player_id:
                        host_player_id = value;
                        break;
                    case CmdParams.logs_enabled:
                        logs_enabled = value.ToLower() == "true";
                        break;
                }
            }

            IsInCloud = !string.IsNullOrEmpty(server_host_domain) && server_host_domain != "localhost" &&
                        server_host_domain != "127.0.0.1";
            IsLocalTest = !IsInCloud;
            if (string.IsNullOrEmpty(logFile))
                logFile = "Log.txt";
            GameServerMode mode;
            Enum.TryParse(game_mode, out mode);
            gameMode = mode;

            Debug.Log($"server reads command line args:\n{string.Join(" ", commandLineArgs)}\nIsInCloud={IsInCloud}");

            //Debug.Log("read player id = " + host_player_id);
            /*if (!IsInCloud)
            {
                // setting default local settings.
                server_host_port = 7777;
            }*/

            //Debug.LogFormat("Settings parse result:\ngame_id={0}\ngame_build_version={1}\ngame_mode={2}\nserver_host_domain={3}\n" +
            //     "server_host_port={4}\nserver_host_region={5}\nplayfab_api_endpoint={6}\ntitle_secret_key={7}\ncustom_data={8}\noutput_files_directory_path={9}",
            //    game_id, game_build_version, game_mode, server_host_domain, server_host_port, server_host_region, playfab_api_endpoint, title_secret_key, custom_data, output_files_directory_path);
        }


        public static int FPS
        {
            get
            {
                switch (gameMode)
                {
                    case GameServerMode.Meta: return meta_fps;
                    default: throw new GameException();
                }
            }
        }
    }
}