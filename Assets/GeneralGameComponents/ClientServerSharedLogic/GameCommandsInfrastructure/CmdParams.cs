using System;
using GameTemplate;

namespace Game
{
    public class CmdParams
    {
        public const string game_id = "game_id";
        public const string game_build_version  = "game_build_version";
        public const string game_mode  = "game_mode";
        public const string server_host_domain  = "server_host_domain";
        public const string server_host_port  = "server_host_port";
        public const string server_host_region  = "server_host_region";
        public const string playfab_api_endpoint  = "playfab_api_endpoint";
        public const string title_secret_key  = "title_secret_key";
        public const string custom_data  = "custom_data";
        public const string logFile  = "logFile";
        public const string output_files_directory_path  = "output_files_directory_path";
        public const string battle_step_ms  = "battle_step_ms";
        public const string logs_enabled = "logs_enabled";
        public const string host_player_id  = "host_player_id";
        public const string battle_fps = "battle_fps";
        public const string meta_fps = "meta_fps";
        public const string tournament_fps = "tournament_fps";
        public static string CreateCustomDataForStartBattleOnPlayfab(string host_player_id)
        {
            return $" -{CmdParams.host_player_id}={host_player_id}";
        }
        public static string CreateForLoadTestClient()
        {
            const bool localServer = false;
            return $"-ind %%A -localServer {localServer} -logFile \"log load test client %%A.txt\" {headlessParams}";
        }
        const string region = "EUWest";
        public static string CreateForLocalBattle(string lobbyId, string playerId)
        {
            int port = ConnectionInfo.CreateLocalBattle().port;
            const string logFile = "log battle server.txt";
            //const Region region = Region.EUWest;
            string customData = CreateCustomDataForStartBattleOnPlayfab(playerId);
            const bool logs_enabled = true;
            const bool headless = true;
            throw new NotImplementedException();
            // return Create(lobbyId, VersionManager.CurrBuildVersion, GameServerMode.Battle.ToString(), "localhost", port.ToString(), region.ToString(), 
            //     "test_playfab_api_endpoint", "test_title_secret_key", customData, logFile, 
            //     "test_output_files_directory_path", headless, logs_enabled);
        }
        public static string CreateForLocalMeta()
        {
            int port = ConnectionInfo.CreateLocalMeta().port;
            const string logFile = "log meta server.txt";
            const bool logs_enabled = false;
            const bool headless = true;
            //const Region region = Region.EUWest;
            return Create(string.Empty, VersionManager.CurrBuildVersion, GameServerMode.Meta.ToString(), 
                string.Empty, port.ToString(), region.ToString(), string.Empty, string.Empty, string.Empty, logFile, 
                string.Empty, headless, logs_enabled);
        }
        public static string CreateForForPlayfabTemplate()
        {
            const bool logs_enabled = false;
            return Create("<game_id>", "<game_build_version>", "<game_mode>", 
                "<server_host_domain>", "<server_host_port>", "<server_host_region>", "<playfab_api_endpoint>",
                "<title_secret_key>", "<custom_data>", "<log_file_path>", "<output_files_directory_path>", 
                true, logs_enabled);
        }
        private static string Create(string game_id, string game_build_version, string game_mode, 
            string server_host_domain, string server_host_port, string server_host_region, string playfab_api_endpoint,
            string title_secret_key, string custom_data, string logFile, string output_files_directory_path, bool headless,
            bool logs_enabled)
        {
            const int battle_fps = 30;
            const int meta_fps = 50;
            const int battle_step_ms = 50;
            const int tournament_fps = 30;
            return
                $" -{CmdParams.game_id}={game_id}" +
                $" -{CmdParams.game_build_version}={game_build_version}" +
                $" -{CmdParams.game_mode}={game_mode} -{CmdParams.server_host_domain}={server_host_domain}" +
                $" -{CmdParams.server_host_port}={server_host_port}" +
                $" -{CmdParams.server_host_region}={server_host_region}" +
                $" -{CmdParams.playfab_api_endpoint}={playfab_api_endpoint}" +
                $" -{CmdParams.title_secret_key}={title_secret_key}" +
                $" -{CmdParams.custom_data}={custom_data}" +
                $" -{CmdParams.logFile} \"{logFile}\"" +
                $" -{CmdParams.output_files_directory_path}={output_files_directory_path}" +
                $" {(headless? headlessParams : string.Empty)}" +
                $" -{CmdParams.battle_fps}={battle_fps}" +
                $" -{CmdParams.meta_fps}={meta_fps}" +
                $" -{CmdParams.tournament_fps}={tournament_fps}" +
                $" -{CmdParams.battle_step_ms}={battle_step_ms}" +
                $" -{CmdParams.logs_enabled}={logs_enabled}";
        }
        const string headlessParams = "-batchmode -nographics";
    }
}