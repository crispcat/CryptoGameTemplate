namespace GameServer.Endpoints
{
    using Logging;
    using Mirror.SimpleWeb;
    using System.Security.Authentication;

    public static class WebSocketConfigs
    {
        static WebSocketConfigs()
        {
            Mirror.SimpleWeb.Log.level = ServerConstants.MIRROR_LOG_LEVEL;
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
        };

        public static SslConfig NoSsl = new SslConfig(
            enabled:       false,
            certPath:      string.Empty,
            certPassword:  string.Empty,
            sslProtocols:  SslProtocols.None
        );
    }
    
    public struct WebSocketConfig
    {
        // Protect against allocation attacks by keeping the max message size small.
        // Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out
        // of memory after allocating multiple large packets.
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
    }
}