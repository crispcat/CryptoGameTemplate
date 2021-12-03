using System;
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
            
            GameserverSDK.Start();
            GameserverSDK.RegisterHealthCallback(IsHealthy);
            GameserverSDK.RegisterShutdownCallback(OnShutdown);
            GameserverSDK.RegisterMaintenanceCallback(OnMaintenanceScheduled);
        }
        
        private static bool isListening;
        private static CancellationTokenSource cts;

        private static void Listen()
        {
            isListening = true;
            cts = new CancellationTokenSource();
            
            using var tcpEndpoint = new TcpEndpoint(ServerConfig.endpointPort);
            while (isListening)
            {
                Logs.Message($"Game server is listening on port {ServerConfig.endpointPort.ToString()}");
                var session = tcpEndpoint.WaitForConnection(cts.Token);
                if (session != null)
                    Logs.Message($"Server accepted TCP connection. Session: {session}");
            }
        }

        private static bool IsHealthy()
        {
            return true;
        }

        private static void OnShutdown()
        {
            isListening = false;
            cts.Cancel();
            LoggerService.Dispose();
            Logs.Message("Game server terminated successfully.");
        }
        
        private static void OnMaintenanceScheduled(DateTimeOffset dtOffset)
        {
            LoggerService.Warning($"Maintenance will processed in {DateTime.Now.AddTicks(dtOffset.Ticks)}");
        }
    }
}