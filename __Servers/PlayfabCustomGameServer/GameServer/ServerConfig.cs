using System.Net;
using System.Collections.Generic;
using Microsoft.Playfab.Gaming.GSDK.CSharp;

namespace GameServer
{
    public static class ServerConfig
    {
        public static IPAddress publicIP { get; private set; }
        public static int endpointPort { get; private set; }
        public static int logsPort { get; private set; }
        
        public static void Parse(IDictionary<string, string> config)
        {
            publicIP = IPAddress.Parse(config[GameserverSDK.PublicIpV4AddressKey]);
            logsPort = int.Parse(config[ServerConstants.logsPortName]);
            endpointPort = int.Parse(config[ServerConstants.endpointPortName]);
        }
    }
}