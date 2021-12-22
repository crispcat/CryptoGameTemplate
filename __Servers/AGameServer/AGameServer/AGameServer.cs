namespace AGameServer
{
    using System;
    using Logging;
    using Sessions;
    using Endpoints;
    using System.Linq;
    using DataRouting;
    using HostingProviders;
    using System.Threading;
    
    using static Logging.Logs;

    public static class AGameServer
    {
        public static AGameServerConfig ServerConfig;
        
        private static HostingProviderImpl hostingProvider;
        private static WebSocketEndpoint wssEndpoint;
        private static Thread logStatusThread;
        private static bool awoke;

        static AGameServer()
        {
            ServerConfig = AGameServerConfig.Default;
        }

        public static void Create()
        {
            wssEndpoint = new WebSocketEndpoint();
        }

        public static void SetConfig(AGameServerConfig config)
        {
            ServerConfig = config;
        }

        public static void AddDataRoutingService(IDataRoutingService r_service)
        {
            wssEndpoint.DataService(r_service);
        }

        public static void AddSessionsService(ISessionsService s_service)
        {
            wssEndpoint.SessionsService(s_service);
        }

        public static void Awake()
        {
            if (awoke)
                return;
            
            awoke = true;
            
            InitializeProvider();
            InitializeLogger();
            InitializeEndpoint();
            Ready();
        }

        private static void InitializeProvider()
        {
            hostingProvider = ServerConfig.PROVIDER switch
            {
                HostingProvider.Playfab      =>  new Playfab(),
                HostingProvider.Localhost    =>  new Localhost(),
                HostingProvider.AwsGameLift  =>  new AwsGameLift(),

                _ => throw new NotImplementedException($"Hosting provider {ServerConfig.PROVIDER} is not implemented.")
            };
            
            hostingProvider.Initialize();
        }
        
        private static void InitializeLogger()
        {
            if (!ServerConfig.LOG_STATUS)
                return;
            
            LoggerService.StartListeningForLoggerConnection(hostingProvider.GetPort(ServerConfig.LOGS_PORT_NAME));
            logStatusThread = new Thread(() => SafeInvoke(LogStatus)()) { IsBackground = true };
            logStatusThread.Start();
        }
        
        private static void LogStatus()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(ServerConfig.LOG_STATUS_DELTA);
                    ServerConfig.STATUS_PRINTERS.ForEach(h => Message(h()));
                }
            }
            catch (Exception e)
            {
                Message($"Exception while processing log status: {e}");
            }
        }
        
        private static void InitializeEndpoint()
        {
            wssEndpoint
                .OnPort(hostingProvider.GetPort(ServerConfig.ENDPOINT_PORT_NAME))
                .Awake();
        }

        private static void Ready()
        {
            hostingProvider.Ready();
        }

        public static string SessionsString()
        {
            var connections = wssEndpoint.GetConnections();
            return connections.Count == 0 
                ? "none" 
                : connections.Select(c => $"(id:{c} IP:{wssEndpoint.GetClientAddress(c)}), ")
                             .Aggregate(string.Concat);
        }

        public static bool ValidatePlayerSession(string sessionId)
        {
            return hostingProvider.PlayerSessionIsValid(sessionId);
        }

        public static void Dispose()
        {
            Message("Terminating server...");
            
            wssEndpoint.Dispose();
            LoggerService.Dispose();
            
            Message("AGameServer: bye-bye.");
        }
    }
}