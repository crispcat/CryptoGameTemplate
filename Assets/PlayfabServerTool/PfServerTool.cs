#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayFab;
using UnityEngine;
using PlayFab.MultiplayerModels;
using PlayFab.AuthenticationModels;

namespace PlayFabServerTool
{
    public static class PfServerTool
    {
        public static event Action ServersStateUpdated;
        
        private static bool collecting = false;
        
        public static string serversState;
        private static StringBuilder stateSb;

        private static void Error(PlayFabError error)
        {
            Debug.LogError(error.GenerateErrorReport());
            collecting = false;
        }
        
        public static void UpdateServersState()
        {
            if (collecting)
                return;

            collecting = true;
            stateSb = new StringBuilder();

            // get highest access rights as "title"
            var request = new GetEntityTokenRequest
            {
                Entity = new PlayFab.AuthenticationModels.EntityKey
                {
                    Id = PlayFabSettings.TitleId,
                    Type = "title"
                },
            };
            
            Debug.Log("Authenticating...");
            
            PlayFabAuthenticationAPI.GetEntityToken(request, 
                GatherServersData, 
                Error);
        }
        
        private static async void GatherServersData(GetEntityTokenResponse res)
        {
            Debug.Log("Collecting builds...");
            
            var buildsReq = await PlayFabMultiplayerAPIAsync.ListBuildSummariesV2(new ListBuildSummariesRequest());
            if (buildsReq.fail)
            {
                Error(buildsReq.Error);
                return;
            }

            // iterate builds
            foreach (var buildSummary in buildsReq.Result.BuildSummaries)
            {
                stateSb.AppendLine($"Build ID: {buildSummary.BuildId}");
                stateSb.AppendLine($"Build name: {buildSummary.BuildName}");

                // iterate regions
                foreach (var regionConfiguration in buildSummary.RegionConfigurations)
                {
                    stateSb.AppendLine($"Region {regionConfiguration.Region}:");
                    stateSb.AppendLine($"Status: {regionConfiguration.Status}");

                    Debug.Log("Collecting sessions data...");

                    // in fact, there are all sessions of dedicated server build
                    var sessionsReq = await PlayFabMultiplayerAPIAsync.ListMultiplayerServers(
                        new ListMultiplayerServersRequest
                        {
                            BuildId = buildSummary.BuildId,
                            Region = regionConfiguration.Region
                        }
                    );
                    
                    if (sessionsReq.fail)
                    {
                        Error(sessionsReq.Error);
                        return;
                    }

                    stateSb.AppendLine("Sessions: ");
                    stateSb.AppendLine();

                    if (sessionsReq.Result.MultiplayerServerSummaries.Count == 0)
                        stateSb.AppendLine("No active sessions");

                    // iterate sessions
                    foreach (var sessionData in sessionsReq.Result.MultiplayerServerSummaries)
                    {
                        stateSb.AppendLine($"Session ID: {sessionData.SessionId}");
                        stateSb.AppendLine($"Server ID: {sessionData.ServerId}");
                        stateSb.AppendLine($"State: {sessionData.State}");

                        if (sessionData.State == "StandingBy")
                            continue;
                        
                        // get physical details such as ip and ports
                        var sessionDetailsReq = await PlayFabMultiplayerAPIAsync.GetMultiplayerServerDetails(
                            new GetMultiplayerServerDetailsRequest()
                            {
                                BuildId = buildSummary.BuildId,
                                SessionId = sessionData.SessionId,
                                Region = sessionData.Region,
                            }
                        );
                        
                        if (sessionDetailsReq.fail)
                        {
                            Error(sessionDetailsReq.Error);
                            return;
                        }
                        
                        stateSb.AppendLine($"IP: {sessionDetailsReq.Result.IPV4Address}");
                        stateSb.AppendLine($"Ports: {sessionDetailsReq.Result.Ports.ToPortsString()}");
                        stateSb.AppendLine();
                    }
                }
                
                stateSb.AppendLine("------------------------------------------------");
            }
            
            Done();
        }

        private static void Done()
        {
            Debug.Log("Done.");
            
            stateSb.AppendLine();
            serversState = stateSb.ToString();
            collecting = false;

            ServersStateUpdated?.Invoke();
        }

        public static async void AllocateServerSession(string buildId, string region)
        {
            var requestServerReq = await PlayFabMultiplayerAPIAsync.RequestMultiplayerServer(
                new RequestMultiplayerServerRequest
                {
                    BuildId = buildId,
                    SessionId = Guid.NewGuid().ToString(),
                    PreferredRegions = new List<string> {region},
                }
            );
            
            if (requestServerReq.fail)
            {
                Error(requestServerReq.Error);
                return;
            }
            
            Debug.Log("Server allocated!");
            Debug.Log(requestServerReq.Result.ToJson());
        }

        public static async void KillServerSession(string sessionId)
        {
            var killServerReq = await PlayFabMultiplayerAPIAsync.ShutdownMultiplayerServer(
                new ShutdownMultiplayerServerRequest
                {
                    SessionId = sessionId
                }
            );
            
            if (killServerReq.fail)
            {
                Error(killServerReq.Error);
                return;
            }
            
            Debug.Log($"Server session {sessionId} killed!");
            Debug.Log(killServerReq.Result.ToJson());
        }
    }

    public static class Ext
    {
        public static string ToPortsString(this List<Port> ports)
        {
            return ports.Select(p => p.ToJson() + "\n").Aggregate((p1, p2) => p1 + p2);
        }
    }
}
#endif