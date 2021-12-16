namespace AGameServer.HostingProviders
{
    using System;
    using Logging;
    using System.Net;
    using Aws.GameLift;
    using System.Net.Sockets;
    using Aws.GameLift.Server;
    using Aws.GameLift.Server.Model;
    using System.Collections.Generic;
    
    using static AGameServer;

    public class AwsGameLift : HostingProviderImpl
    {
        private readonly Dictionary<string, int> allocatedPorts = new Dictionary<string, int>();

        private GenericOutcome processReady;
        
        public override void Initialize()
        {
             var initSDK = GameLiftServerAPI.InitSDK();
             PrintStatus(initSDK, nameof(GameLiftServerAPI.InitSDK));
        }

        public override void Ready()
        {
            processReady = GameLiftServerAPI.ProcessReady(new ProcessParameters
            {
                Port                 = GetPort(ServerConfig.ENDPOINT_PORT_NAME),
                LogParameters        = new LogParameters(new List<string> { $"proc_{Guid.NewGuid()}_log" }),
                OnStartGameSession   = OnStartGameSession,
                OnUpdateGameSession  = OnUpdateGameSession,
                OnHealthCheck        = OnHealthCheck,
                OnProcessTerminate   = OnProcessTerminate,
            });
            
            PrintStatus(processReady, nameof(GameLiftServerAPI.ProcessReady));
        }

        public override bool PlayerSessionIsValid(string sessionId)
        {
            var acceptPlayerSession = GameLiftServerAPI.AcceptPlayerSession(sessionId);
            PrintStatus(acceptPlayerSession, nameof(GameLiftServerAPI.AcceptPlayerSession));

            if (acceptPlayerSession.Success)
            {
                Logs.Message($"$Game Lift: player session {sessionId} just landed.");
                return true;
            }

            return false;
        }

        private void OnStartGameSession(GameSession gamesession)
        {
            Logs.Message($"Game Lift: game session {gamesession.Name} placed on server.");
            
            var activateGameSession = GameLiftServerAPI.ActivateGameSession();
            PrintStatus(activateGameSession, nameof(GameLiftServerAPI.ActivateGameSession));
        }
        
        private void OnUpdateGameSession(UpdateGameSession updategamesession)
        {
            Logs.Message($"Game Lift: game session updated {updategamesession.GameSession.Name}");
        }

        private bool OnHealthCheck()
        {
            return checkHealth();
        }

        private void OnProcessTerminate()
        {
            InvokeShutdown();
            
            var processEnding = GameLiftServerAPI.ProcessEnding();
            PrintStatus(processEnding, nameof(GameLiftServerAPI.ProcessEnding));
            
            if (processReady.Success)
                Environment.Exit(0);
            
            Environment.Exit((int)processReady.Error.ErrorType);
        }
        
        private void PrintStatus(GenericOutcome outcome, string method)
        {
            if (outcome.Success)
                Logs.Message($"Game Lift: {method} succeed.");
            else
                Logs.Error($"Game Lift error: {outcome.Error.ErrorMessage}");
        }

        public override int GetPort(string name)
        {
            if (!allocatedPorts.TryGetValue(name, out int port))
            {
                port = FindFreeTcpPort();
                allocatedPorts.Add(name, port);
            }
            
            return port;
        }
        
        private static int FindFreeTcpPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            
            return port;
        }
    }
}