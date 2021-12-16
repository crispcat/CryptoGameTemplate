namespace AGameServer.HostingProviders
{
    using System;
    using Logging;
    using Microsoft.Playfab.Gaming.GSDK.CSharp;

    public class Playfab : HostingProviderImpl
    {
        public override void Initialize()
        {
            try
            {
                GameserverSDK.Start();
                GameserverSDK.RegisterHealthCallback(IsHealthy);
                GameserverSDK.RegisterShutdownCallback(OnShutdown);
                GameserverSDK.RegisterMaintenanceCallback(OnMaintenanceScheduled);
            }
            catch (GSDKInitializationException e)
            {
                Console.WriteLine($"Cannot start GSDK. Please make sure the MockAgent is running or you build configuration is correct. Exception: {e}");
                Console.WriteLine("Running in standalone mode...");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Server awoke with exception: {e}");
            }
        }

        public override bool PlayerSessionIsValid(string sessionId)
        {
            return true;
        }

        public override int GetPort(string name)
        {
            return int.Parse(GameserverSDK.getConfigSettings()[name]);
        }

        private bool IsHealthy()
        {
            return checkHealth();
        }

        private void OnShutdown()
        {
            InvokeShutdown();
        }
        
        private void OnMaintenanceScheduled(DateTimeOffset dtOffset)
        {
            Logs.Warning($"Maintenance will processed in {DateTime.Now.AddTicks(dtOffset.Ticks)}");
        }

        public override void Ready()
        {
            if (GameserverSDK.ReadyForPlayers())
                Logs.Message("Ready for players!");
            else
                Logs.Message("Server is getting terminated.");
        }
    }
}