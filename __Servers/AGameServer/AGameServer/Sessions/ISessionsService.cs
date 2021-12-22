namespace AGameServer.Sessions
{
    using Endpoints;

    public interface ISessionsService
    {
        IEndpoint endpoint { get; set; }

        void CreateSession(int sessionId);
        void EndSession(int sessionId);
    }
}