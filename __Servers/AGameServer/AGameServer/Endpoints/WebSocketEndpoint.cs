namespace AGameServer.Endpoints
{
    using System;
    using Sessions;
    using DataRouting;
    using Mirror.SimpleWeb;
    using System.Threading;
    using System.Collections.Generic;

    using static WebSocketConfigs;
    using static Logging.Logs;

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

        private Thread[] processMessagesThreads;

        public WebSocketEndpoint()
        {
            onConnectCallbacks     = new List<Action<int>>();
            onDisconnectCallbacks  = new List<Action<int>>();
            onDataCallbacks        = new List<Action<int, ArraySegment<byte>>>();
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
            onConnectCallbacks.Add(SafeInvoke(onConnect));
            return this;
        }

        public WebSocketEndpoint SubData(Action<int, ArraySegment<byte>> onData)
        {
            onDataCallbacks.Add(SafeInvoke(onData));
            return this;
        }

        public WebSocketEndpoint SubDisconnect(Action<int> onDisconnect)
        {
            onDisconnectCallbacks.Add(SafeInvoke(onDisconnect));
            return this;
        }

        public WebSocketEndpoint SessionsService(ISessionsService sessionsService)
        {
            sessionsService.endpoint = this;
            onConnectCallbacks.Add(SafeInvoke<int>(sessionsService.CreateSession));
            onDisconnectCallbacks.Add(SafeInvoke<int>(sessionsService.EndSession));
            
            return this;
        }

        public WebSocketEndpoint DataService(IDataRoutingService dataRoutingService)
        {
            dataRoutingService.endpoint = this;
            onDataCallbacks.Add(SafeInvoke<int, ArraySegment<byte>>(dataRoutingService.ProcessData));

            return this;
        }

        public WebSocketEndpoint Awake()
        {
            if (port == null)
            {
                Error("WebSocketEndpoint: port is not provided.");
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

            processMessagesThreads = new Thread[config.threads];
            
            for (int i = 0; i < config.threads; i++)
            {
                processMessagesThreads[i] = new Thread(() => SafeInvoke(ProcessMessages)()) { IsBackground = false };
                processMessagesThreads[i].Start();
            }

            return this;
        }
        
        private bool hasProcessMessages = true;

        private void ProcessMessages()
        {
            try
            {
                while (hasProcessMessages)
                    server.ProcessMessageQueue();
            }
            catch (Exception e)
            {
                Message($"Exception while processing incoming messages: {e}");
            }
        }

        public void Send(int sessionId, ArraySegment<byte> data)
        {
            server.SendOne(sessionId, data);
        }

        public void Send(List<int> sessionIds, ArraySegment<byte> data)
        {
            server.SendAll(sessionIds, data);
        }

        public void Broadcast(ArraySegment<byte> data)
        {
            var allConnectionIds = server.GetActiveConnections();
            server.SendAll(allConnectionIds, data);
        }

        public List<int> GetConnections()
        {
            return server.GetActiveConnections();
        }
        
        public string GetClientAddress(int connectionId)
        {
            return server.GetClientAddress(connectionId);
        }

        public void Dispose()
        {
            server.Stop();
            hasProcessMessages = false;
        }
    }
}