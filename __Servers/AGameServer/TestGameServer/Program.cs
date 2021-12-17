namespace TestGameServer
{
    using System;
    using AGameServer;
    using AGameServer.Sessions;
    using AGameServer.Endpoints;
    using AGameServer.DataRouting;
    using ClientServerSharedLogic;
    using System.Collections.Generic;
    
    using static AGameServer.AGameServer;
    using static AGameServer.Logging.Logs;

    public class TestSessionsService : ISessionsService
    {
        public IEndpoint endpoint { get; set; }
        
        public void CreateSession(int sessionId)
        {
            Message($"Server accepted WSS connection. SessionId: {sessionId}");
            endpoint.Send(sessionId, $"Greetings, my {sessionId}th buddy!".Bytes());
        }

        public void EndSession(int sessionId)
        {
            Message($"WSS client session {sessionId} disconnected.");
        }
    }

    public class TestDataService : IDataRoutingService
    {
        public IEndpoint endpoint { get; set; }
        
        public void ProcessData(int sessionId, ArraySegment<byte> data)
        {
            Message($"Buddy {sessionId} talks : {data.WideString()}");
        }
    }

    public static class Program
    {
        private static readonly AGameServerConfig config = new AGameServerConfig
        {
            PROVIDER = HostingProvider.Localhost,
            STATUS_PRINTERS = new List<Func<string>>
            {
                () => $"Server is running. Active sessions: {SessionsString()}"
            }
        };

        private static void Main(string[] args)
        {
            SafeInvoke(GameServer)();
        }

        private static void GameServer()
        {
            Create();
            SetConfig(config);
            AddSessionsService(new TestSessionsService());
            AddDataRoutingService(new TestDataService());
            Awake();
        }
    }
}