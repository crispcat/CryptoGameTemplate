namespace AGameServer.HostingProviders
{
    using System.Net;
    using System.Collections.Generic;
    
    using static AGameServer;

    public class Localhost : HostingProviderImpl
    {
        private readonly Dictionary<string, int> ports = new Dictionary<string, int>
        {
            { ServerConfig.ENDPOINT_PORT_NAME, ServerConfig.ENPOINT_FALLBACK_PID },
            { ServerConfig.LOGS_PORT_NAME,     ServerConfig.LOGS_FALLBACK_PID }
        };

        public override void Initialize() { }

        public override void Ready() { }

        public override bool PlayerSessionIsValid(string sessionId) => true;

        public override int GetPort(string name)
        {
            return ports[name];
        }
    }
}