namespace GameServer
{
    using System;
    using Logging;
    using Endpoints;
    using System.Text;
    using Microsoft.Playfab.Gaming.GSDK.CSharp;
    
    internal static class Program
    {
        private static WebSocketEndpoint wssEndpoint;

        private static void Main(string[] args)
        {
            try
            {
                Awake();
            }
            catch (GSDKInitializationException e)
            {
                Console.WriteLine($"Cannot start GSDK. Please make sure the MockAgent is running or you build configuration is correct. Exception: {e}");
                return;
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
            
            if (GameserverSDK.ReadyForPlayers())
                Logs.Message("Ready for players!");
            else
                Logs.Message("Server is getting terminated.");
        }
        
        private static void Awake()
        {
            var config = GameserverSDK.getConfigSettings();
            
            ServerConfig.Parse(config);
            LoggerService.StartListeningForLoggerConnection();
            LoggerService.StartPingLoggerClients();
            
            GameserverSDK.Start();
            GameserverSDK.RegisterHealthCallback(IsHealthy);
            GameserverSDK.RegisterShutdownCallback(OnShutdown);
            GameserverSDK.RegisterMaintenanceCallback(OnMaintenanceScheduled);
        }

        private static void OnConnect(int sessionId)
        {
            Logs.Message($"Server accepted WSS connection. SessionId: {sessionId}");
        }
        
        private static void OnData(int sessionId, ArraySegment<byte> data)
        {
            var message = Encoding.ASCII.GetString(data);
            Logs.Message($"Session {sessionId} talks : {message}");
        }

        private static void OnDisconnect(int sessionId)
        {
            Logs.Message($"WSS client session {sessionId} disconnected.");
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