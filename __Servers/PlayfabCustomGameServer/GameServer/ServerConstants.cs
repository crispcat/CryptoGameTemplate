namespace GameServer
{
    using static Mirror.SimpleWeb.Log;

    public static class ServerConstants
    {
        // CONFIGS
        public const string  LOGS_PORT_NAME      = "logs";
        public const string  ENDPOINT_PORT_NAME  = "endpoint";
        
        // LOGS
        public const Levels  MIRROR_LOG_LEVEL   = Levels.verbose;
        public const bool    LOG_STATUS         = true;
        public const int     LOG_STATUS_DELTA   = 5_000;

        //  WSS
        /// <summary>
        /// Protect against allocation attacks by keeping the max message size small.
        /// Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out
        /// of memory after allocating multiple large packets.
        /// </summary>
        public const int WSS_MAX_MESSAGE_SIZE = 16 * 1024;
        /// <summary>
        /// Max size for http header send as handshake for websockets.
        /// </summary>
        public const int WSS_HANDSHAKE_MAX_SIZE = 3000;
        /// <summary>
        /// Disables nagle algorithm.
        /// Lowers CPU% and latency but increases bandwidth
        /// </summary>
        public const bool WSS_NO_DELAY = true;
        /// <summary>
        /// Send would stall forever if the network is cut off during a send, so we need a timeout (in milliseconds)
        /// </summary>
        public const int WSS_SEND_TIMEOUT = 7_000;
        /// <summary>
        /// How long without a message before disconnecting (in milliseconds)
        /// </summary>
        public const int WSS_RECEIVE_TIMEOUT = 10_000;
        /// <summary>
        /// Caps the number of messages the server will process per tick.
        /// </summary>
        public const int WSS_MESSAGES_PER_TICK = 10_000;
        /// <summary>
        /// Number of threads processing incoming messages
        /// </summary>
        public const int ENDPOINT_THREADS = 1;
    }
}