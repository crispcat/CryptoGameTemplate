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
            maxMessageSize      = ServerConstants.WSS_MAX_MESSAGE_SIZE,
            handshakeMaxSize    = ServerConstants.WSS_HANDSHAKE_MAX_SIZE,
            noDelay             = ServerConstants.WSS_NO_DELAY,
            sendTimeout         = ServerConstants.WSS_SEND_TIMEOUT,
            receiveTimeout      = ServerConstants.WSS_RECEIVE_TIMEOUT,
            maxMessagesPerTick  = ServerConstants.WSS_MESSAGES_PER_TICK,
            threads             = ServerConstants.ENDPOINT_THREADS,
        };

        public static SslConfig NoSsl = new SslConfig(
            enabled:       false,
            certPath:      string.Empty,
            certPassword:  string.Empty,
            sslProtocols:  SslProtocols.Tls12
        );
    }
    
    public struct WebSocketConfig
    {
        /// <summary>
        /// Protect against allocation attacks by keeping the max message size small.
        /// Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out
        /// of memory after allocating multiple large packets.
        /// </summary>
        public int maxMessageSize;
        /// <summary>
        /// Max size for http header send as handshake for websockets.
        /// </summary>
        public int handshakeMaxSize;
        /// <summary>
        /// Disables nagle algorithm.
        /// Lowers CPU% and latency but increases bandwidth
        /// </summary>
        public bool noDelay;
        /// <summary>
        /// Send would stall forever if the network is cut off during a send, so we need a timeout (in milliseconds)
        /// </summary>
        public int sendTimeout;
        /// <summary>
        /// How long without a message before disconnecting (in milliseconds)
        /// </summary>
        public int receiveTimeout;
        /// <summary>
        /// Caps the number of messages the server will process per tick.
        /// </summary>
        public int maxMessagesPerTick;
        /// <summary>
        /// Number of tasks processing incoming messages.
        /// </summary>
        public int threads;
    }
}