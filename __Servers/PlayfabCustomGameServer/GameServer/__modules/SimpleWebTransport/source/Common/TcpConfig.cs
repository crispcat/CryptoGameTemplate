using System.Net.Sockets;

namespace Mirror.SimpleWeb
{
    public struct TcpConfig
    {
        private readonly bool noDelay;
        private readonly int sendTimeout;
        private readonly int receiveTimeout;

        public TcpConfig(bool noDelay, int sendTimeout, int receiveTimeout)
        {
            this.noDelay = noDelay;
            this.sendTimeout = sendTimeout;
            this.receiveTimeout = receiveTimeout;
        }

        public readonly void ApplyTo(TcpClient client)
        {
            client.SendTimeout = sendTimeout;
            client.ReceiveTimeout = receiveTimeout;
            client.NoDelay = noDelay;
        }
    }
}
