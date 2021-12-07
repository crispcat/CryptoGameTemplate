using System;
using Mirror.SimpleWeb;
using GameServer.Logging;
using System.Security.Authentication;

namespace GameServer
{
    public struct WebSocketConfig
    {
        // Protect against allocation attacks by keeping the max message size small.
        // Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out of memory after allocating multiple large packets.
        public int maxMessageSize;

        // Max size for http header send as handshake for websockets"
        public int handshakeMaxSize;

        // Disables nagle algorithm.
        // Lowers CPU% and latency but increases bandwidth
        public bool noDelay;

        // Send would stall forever if the network is cut off during a send, so we need a timeout (in milliseconds)
        public int sendTimeout;

        // How long without a message before disconnecting (in milliseconds)
        public int receiveTimeout;

        // Caps the number of messages the server will process per tick.
        public int maxMessagesPerTick;

        // Supported SSL protocols 
        public SslProtocols sslProtocols;
    }

    public static class WebSocketConfigs
    {
        public static Mirror.SimpleWeb.Log.Levels logLevel = Mirror.SimpleWeb.Log.Levels.verbose;

        static WebSocketConfigs()
        {
            Mirror.SimpleWeb.Log.level = logLevel;
            Mirror.SimpleWeb.Log.SetLogHandlers(Logs.Message, Logs.Warning, Logs.Error);
        }
        
        public static WebSocketConfig Default = new WebSocketConfig
        {
            maxMessageSize      = 16 * 1024,
            handshakeMaxSize    = 3000,
            noDelay             = true,
            sendTimeout         = 5000,
            receiveTimeout      = 20000,
            maxMessagesPerTick  = 10000,
            sslProtocols        = SslProtocols.Tls12,
        };
    }
    
    public class WebSocketEndpoint : IEndpoint
    {
        private SimpleWebServer webServer;
        private ushort? port;
        
        public WebSocketEndpoint Mode(WebSocketConfig config)
        {
            var tcpConfig = new TcpConfig(
                noDelay:        config.noDelay, 
                sendTimeout:    config.sendTimeout, 
                receiveTimeout: config.receiveTimeout);
            
            var sslConfig = new SslConfig(
                enabled:        false, 
                certPath:       string.Empty, 
                certPassword:   string.Empty, 
                sslProtocols:   config.sslProtocols);

            webServer = new SimpleWebServer(
                tcpConfig:          tcpConfig,
                sslConfig:          sslConfig,
                maxMessageSize:     config.maxMessageSize,
                handshakeMaxSize:   config.handshakeMaxSize,
                maxMessagesPerTick: config.maxMessagesPerTick);

            return this;
        }

        public WebSocketEndpoint OnPort(int port)
        {
            this.port = (ushort) port;
            return this;
        }

        public WebSocketEndpoint Connect(Action<int> onConnect)
        {
            webServer.onConnect += onConnect;
            return this;
        }
        
        public WebSocketEndpoint Data(Action<int, ArraySegment<byte>> onData)
        {
            webServer.onData += onData;
            return this;
        }
        
        public WebSocketEndpoint Disconnect(Action<int> onDisconnect)
        {
            webServer.onDisconnect += onDisconnect;
            return this;
        }

        public WebSocketEndpoint Awake()
        {
            if (port == null)
            {
                Logs.Error("WebSocketEndpoint: port is not provided.");
                return null;
            }
                
            webServer.Start(port.Value);
            return this;
        }

        public void Dispose()
        {
            webServer.Stop();
            webServer = null;
        }
    }
}