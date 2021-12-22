namespace AGameServer.Endpoints
{
    using System;
    using System.Collections.Generic;

    public interface IEndpoint : IDisposable
    {
        void Send(int sessionId, ArraySegment<byte> data);
        void Send(List<int> sessionIds, ArraySegment<byte> data);
        void Broadcast(ArraySegment<byte> data);
        
    }
}