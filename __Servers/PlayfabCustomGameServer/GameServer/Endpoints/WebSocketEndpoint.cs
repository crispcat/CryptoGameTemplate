namespace GameServer.Endpoints
{
    using System;
    using Logging;
    using Sessions;
    using DataRouting;
    using System.Linq;
    using Mirror.SimpleWeb;
    using System.Threading;
    using System.Collections.Generic;

    using static WebSocketConfigs;

    public class WebSocketEndpoint : IEndpoint
    {
        // composition over inheritance ;)
        public SimpleWebServer server { get; private set; }

        private ushort? port;
        private SslConfig sslConfig = NoSsl;
        private WebSocketConfig config = Default;

        private TcpConfig tcpConfig => new TcpConfig(
            noDelay:        config.noDelay,
            sendTimeout:    config.sendTimeout,
            receiveTimeout: config.receiveTimeout);
        
        private readonly List<Action<int>> onConnectCallbacks;
        private readonly List<Action<int>> onDisconnectCallbacks;
        private readonly List<Action<int, ArraySegment<byte>>> onDataCallbacks;

        public WebSocketEndpoint()
        {
            onConnectCallbacks    = new List<Action<int>>();
            onDisconnectCallbacks = new List<Action<int>>();
            onDataCallbacks       = new List<Action<int, ArraySegment<byte>>>();
        }

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
            onConnectCallbacks.Add(onConnect);
            return this;
        }

        public WebSocketEndpoint SubData(Action<int, ArraySegment<byte>> onData)
        {
            onDataCallbacks.Add(onData);
            return this;
        }

        public WebSocketEndpoint SubDisconnect(Action<int> onDisconnect)
        {
            onDisconnectCallbacks.Add(onDisconnect);
            return this;
        }

        public WebSocketEndpoint SessionsService(ISessionsService sessionsService)
        {
            sessionsService.endpoint = this;
            onConnectCallbacks.Add(sessionsService.CreateSession);
            onDisconnectCallbacks.Add(sessionsService.EndSession);
            
            return this;
        }

        public WebSocketEndpoint DataService(IDataRoutingService dataRoutingService)
        {
            dataRoutingService.endpoint = this;
            onDataCallbacks.Add(dataRoutingService.ProcessData);
            
            return this;
        }

        public WebSocketEndpoint Awake()
        {
            if (port == null)
            {
                Logs.Error("WebSocketEndpoint: port is not provided.");
                return null;
            }

            server = new SimpleWebServer(
                tcpConfig:          tcpConfig,
                sslConfig:          sslConfig,
                maxMessageSize:     config.maxMessageSize,
                handshakeMaxSize:   config.handshakeMaxSize,
                maxMessagesPerTick: config.maxMessagesPerTick);

            foreach (var onConnectCallback in onConnectCallbacks)
                server.onConnect += onConnectCallback;
            
            foreach (var onDisconnectCallback in onDisconnectCallbacks)
                server.onDisconnect += onDisconnectCallback;

            foreach (var onDataCallback in onDataCallbacks)
                server.onData += onDataCallback;

            
            server.Start(port.Value);
            
            for (int i = 0; i < config.threads; i++)
                new Thread(ProcessMessages).Start();

            return this;
        }
        
        private bool hasProcessMessages = true;

        private void ProcessMessages()
        {
            while (hasProcessMessages)
                server.ProcessMessageQueue();
        }

        public void Broadcast(ArraySegment<byte> data)
        {
            var allConnectionIds = server.GetActiveConnections();
            server.SendAll(allConnectionIds, data);
        }

        public string SessionsStatus()
        {
            var connections = server.GetActiveConnections();
            return connections.Count == 0 
                ? "none" 
                : connections.Select(c => $"(id:{c} ip:{server.GetClientAddress(c)}), ")
                             .Aggregate(string.Concat);
        }

        public void Dispose()
        {
            server.Stop();
            hasProcessMessages = false;
        }
    }
}