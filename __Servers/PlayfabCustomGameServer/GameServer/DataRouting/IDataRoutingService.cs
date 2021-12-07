namespace GameServer.DataRouting
{
    using System;
    using Endpoints;

    public interface IDataRoutingService
    {
        IEndpoint endpoint { get; set; }

        void ProcessData(int sessionId, ArraySegment<byte> data);
    }
}