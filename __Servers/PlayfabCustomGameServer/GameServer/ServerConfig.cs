namespace GameServer
{
    using System.Net;
    using System.Collections.Generic;
    using Microsoft.Playfab.Gaming.GSDK.CSharp;
    
    public static class ServerConfig
    {
        public static IPAddress publicIp { get; private set; }
        public static int endpointPort { get; private set; }
        public static int logsPort { get; private set; }
        
        public static void Parse(IDictionary<string, string> config)
        {
            publicIp = IPAddress.Parse(config[GameserverSDK.PublicIpV4AddressKey]);
            logsPort = int.Parse(config[ServerConstants.LOGS_PORT_NAME]);
            endpointPort = int.Parse(config[ServerConstants.ENDPOINT_PORT_NAME]);
        }
    }
}