using System;
using System.Net;
using GameServer.Logging;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace GameServer
{
    public class TcpSession
    {
        private TcpClient client;

        public readonly IPAddress ip;

        public NetworkStream GetStream() => client.GetStream();
        
        public TcpSession(TcpClient client)
        {
            this.client = client;
            ip = ((IPEndPoint) client.Client.RemoteEndPoint).Address;
        }

        public override string ToString()
        {
            return $"client(ip: {ip})";
        }
    }
    
    public class TcpEndpoint : IDisposable
    {
        private readonly TcpListener tcpListener;

        public TcpEndpoint(int port)
        {
            tcpListener = TcpListener.Create(port);
            tcpListener.Start();
        }

        public TcpSession WaitForConnection(CancellationToken ct)
        {
            if (ct.IsCancellationRequested)
                return null;
            
            try
            {
                var acceptedClient = tcpListener.AcceptTcpClientAsync();
                acceptedClient.Wait(ct);
                
                return new TcpSession(acceptedClient.Result);
            }
            catch (OperationCanceledException)
            {
                Logs.Message("TcpEndpoint: Listening TCP endpoint canceled.");
                return null;
            }
            catch (Exception e)
            {
                Logs.Error($"TcpEndpoint: Error occured on accepting TCP client connection: {e}");
                return null;
            }
        }

        public void Dispose()
        {
            tcpListener.Stop();
        }
    }
}