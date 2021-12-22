namespace AGameServer
{
    using System;
    using System.Collections.Generic;
    
    using static Mirror.SimpleWeb.Log;
    
    public enum HostingProvider
    {
        AwsGameLift, Playfab, Localhost
    }

    public class AGameServerConfig
    {
        public static readonly AGameServerConfig Default = new AGameServerConfig();

        //  GENERAL                                            DEFAULT VALUES
        public HostingProvider     PROVIDER                    = HostingProvider.AwsGameLift;
        public string              ENDPOINT_PORT_NAME          = "endpoint";
        public ushort              PORT_RANGE_MIN              = 30000;
        public ushort              PORT_RANGE_MAX              = 40000;
     
        //  LOGS
        public string              LOGS_PORT_NAME              = "logs";
        public Levels              MIRROR_LOG_LEVEL            = Levels.verbose;
        public bool                LOG_STATUS                  = true;
        public int                 LOG_STATUS_DELTA            = 5_000;
        public int                 LG_MAX_MESSAGE_SIZE         = 4 * 1024;
        public int                 LG_MIN_MESSAGE_SIZE         = 20;
        public int                 LG_MAX_MESSAGES_PER_TICK    = 1000;
        public int                 LG_SEND_PERIOD              = 200;
        
        //  ACTIONS
        public Action              ON_SHUTDOWN                 = () => { };
        public Func<bool>          HEALTH_CHECK                = () => true;
        public List<Func<string>>  STATUS_PRINTERS             = new List<Func<string>>();

        //  WSS
        /// <summary>
        /// Protect against allocation attacks by keeping the max message size small.
        /// Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out
        /// of memory after allocating multiple large packets.
        /// </summary>
        public int WSS_MAX_MESSAGE_SIZE = 16 * 1024;
        /// <summary>
        /// Max size for http header send as handshake for websockets.
        /// </summary>
        public int WSS_HANDSHAKE_MAX_SIZE = 3000;
        /// <summary>
        /// Disables nagle algorithm.
        /// Lowers CPU% and latency but increases bandwidth
        /// </summary>
        public bool WSS_NO_DELAY = true;
        /// <summary>
        /// Send would stall forever if the network is cut off during a send, so we need a timeout (in milliseconds)
        /// </summary>
        public int WSS_SEND_TIMEOUT = 7_000;
        /// <summary>
        /// How long without a message before disconnecting (in milliseconds)
        /// </summary>
        public int WSS_RECEIVE_TIMEOUT = 30_000;
        /// <summary>
        /// Caps the number of messages the server will process per tick.
        /// </summary>
        public int WSS_MESSAGES_PER_TICK = 10_000;
        /// <summary>
        /// Number of threads processing incoming messages
        /// </summary>
        public int ENDPOINT_THREADS = 1;
    }
}