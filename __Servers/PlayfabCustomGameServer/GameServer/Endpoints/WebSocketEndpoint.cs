namespace GameServer.Endpoints
{
    using System;
    using Logging;
    using Sessions;
    using DataRouting;
    using Mirror.SimpleWeb;
    using static WebSocketConfigs;

    public class WebSocketEndpoint : IEndpoint
    {
        private SimpleWebServer webServer;

        private ushort? port;
        private SslConfig sslConfig = NoSsl;
        private WebSocketConfig config = Default;

        private TcpConfig tcpConfig => new TcpConfig(
            noDelay:        config.noDelay,
            sendTimeout:    config.sendTimeout,
            receiveTimeout: config.receiveTimeout);

        public WebSocketEndpoint WebSocket(WebSocketConfig config)
        {
            this.config = config;
            return this;
        }

        public WebSocketEndpoint SSL(SslConfig sslConfig)
        {
            this.sslConfig = sslConfig;
            return this;
        }

        public WebSocketEndpoint OnPort(int port)
        {
            this.port = (ushort) port;
            return this;
        }

        public WebSocketEndpoint SubConnect(Action<int> onConnect)
        {
            webServer.onConnect += onConnect;
            return this;
        }

        public WebSocketEndpoint SubData(Action<int, ArraySegment<byte>> onData)
        {
            webServer.onData += onData;
            return this;
        }

        public WebSocketEndpoint SubDisconnect(Action<int> onDisconnect)
        {
            webServer.onDisconnect += onDisconnect;
            return this;
        }

        public WebSocketEndpoint SessionsService(ISessionsService sessionsService)
        {
            sessionsService.endpoint = this;
            webServer.onConnect += sessionsService.CreateSession;
            webServer.onDisconnect += sessionsService.EndSession;
            return this;
        }

        public WebSocketEndpoint DataService(IDataRoutingService dataRoutingService)
        {
            dataRoutingService.endpoint = this;
            webServer.onData += dataRoutingService.ProcessData;
            return this;
        }

        public WebSocketEndpoint Awake()
        {
            if (port == null)
            {
                Logs.Error("WebSocketEndpoint: port is not provided.");
                return null;
            }

            webServer = new SimpleWebServer(
                tcpConfig:          tcpConfig,
                sslConfig:          sslConfig,
                maxMessageSize:     config.maxMessageSize,
                handshakeMaxSize:   config.handshakeMaxSize,
                maxMessagesPerTick: config.maxMessagesPerTick);

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