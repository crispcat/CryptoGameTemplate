namespace GameServer
{
    using System;
    using Logging;
    using Endpoints;
    using System.Text;
    using System.Threading;
    using ClientServerSharedLogic;
    using System.Collections.Generic;
    using Microsoft.Playfab.Gaming.GSDK.CSharp;

    internal static class Program
    {
        private static WebSocketEndpoint wssEndpoint;
        private static Thread logStatusThread;

        private static void Main(string[] args)
        {
            try
            {
                if (ServerConstants.USE_PLAYFAB)
                try
                {
                    PfAwake();
                }
                catch (GSDKInitializationException e)
                {
                    Console.WriteLine($"Cannot start GSDK. Please make sure the MockAgent is running or you build configuration is correct. Exception: {e}");
                    Console.WriteLine("Running in standalone mode...");
                    return;
                }
                else
                    AwakeFallback();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Server awoke with exception: {e}");
                return;
            }

            wssEndpoint = new WebSocketEndpoint().OnPort(ServerConfig.endpointPort)
                                                 .SubConnect(OnConnect)
                                                 .SubData(OnData)
                                                 .SubDisconnect(OnDisconnect)
                                                 .Awake();
            if (ServerConstants.LOG_STATUS)
            {
                logStatusThread = new Thread(LogStatus) { IsBackground = true };
                logStatusThread.Start();
            }

            if (ServerConstants.USE_PLAYFAB)
            if (GameserverSDK.ReadyForPlayers())
                Logs.Message("Ready for players!");
            else
                Logs.Message("Server is getting terminated.");
        }
        
        private static void PfAwake()
        {
            var config = GameserverSDK.getConfigSettings();
            
            ServerConfig.Parse(config);
            LoggerService.StartListeningForLoggerConnection();

            GameserverSDK.Start();
            GameserverSDK.RegisterHealthCallback(IsHealthy);
            GameserverSDK.RegisterShutdownCallback(OnShutdown);
            GameserverSDK.RegisterMaintenanceCallback(OnMaintenanceScheduled);
        }

        private static void AwakeFallback()
        {
            ServerConfig.Parse(new Dictionary<string, string>
            {
                {GameserverSDK.PublicIpV4AddressKey,  "127.0.0.1"},
                {ServerConstants.ENDPOINT_PORT_NAME,  "30000"},
                {ServerConstants.LOGS_PORT_NAME,      "30100"}
            });
            
            LoggerService.StartListeningForLoggerConnection();
        }

        private static void OnConnect(int sessionId)
        {
            Logs.Message($"Server accepted WSS connection. SessionId: {sessionId}");
            wssEndpoint.server.SendOne(sessionId, $"Greetings, my {sessionId}th buddy!".Bytes());
        }
        
        private static void OnData(int sessionId, ArraySegment<byte> data)
        {
            var message = Encoding.ASCII.GetString(data);
            Logs.Message($"Buddy {sessionId} talks : {message}");
        }

        private static void OnDisconnect(int sessionId)
        {
            Logs.Message($"WSS client session {sessionId} disconnected.");
        }
        
        private static void LogStatus()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(ServerConstants.LOG_STATUS_DELTA);
                    Logs.Message($"Server is running. Active sessions: {wssEndpoint.SessionsStatus()}");
                }
            }
            catch (Exception e)
            {
                Logs.Message($"Exception while processing log status: {e}");
            }
        }
        
        private static bool IsHealthy()
        {
            return true;
        }

        private static void OnShutdown()
        {
            Logs.Message("Terminating server...");
            
            LoggerService.Dispose();
            wssEndpoint.Dispose();
            
            Logs.Message("Server: bye-bye.");
        }
        
        private static void OnMaintenanceScheduled(DateTimeOffset dtOffset)
        {
            LoggerService.Warning($"Maintenance will processed in {DateTime.Now.AddTicks(dtOffset.Ticks)}");
        }
    }
}