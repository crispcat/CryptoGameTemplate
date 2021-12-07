using System;
using System.Text;
using System.Threading;
using GameServer.Logging;
using Microsoft.Playfab.Gaming.GSDK.CSharp;

namespace GameServer
{
    internal static class Program
    {
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

            // we need to start thread manually, otherwise program will exit
            var listen = new Thread(Listen);
            listen.Start();
            
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
        
        // private static bool isListening;
        // private static CancellationTokenSource cts;

        private static WebSocketEndpoint wssEndpoint;

        private static void Listen()
        {
            wssEndpoint = new WebSocketEndpoint()
                .Mode(WebSocketConfigs.Default)
                .OnPort(ServerConfig.endpointPort)
                .Connect(OnConnect)
                .Data(OnData)
                .Disconnect(OnDisconnect)
                .Awake();

            Logs.Message($"Game server is listening on port {ServerConfig.endpointPort.ToString()}");
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
            wssEndpoint.Dispose();
            LoggerService.Dispose();
            Logs.Message("Game server terminated successfully.");
        }
        
        private static void OnMaintenanceScheduled(DateTimeOffset dtOffset)
        {
            LoggerService.Warning($"Maintenance will processed in {DateTime.Now.AddTicks(dtOffset.Ticks)}");
        }
    }
}