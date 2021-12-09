namespace GameServer.Logging
{
    using System;
    using System.Net;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Net.Sockets;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public static class LoggerService
    {
        private static bool isListening;
        private static TcpListener loggerEndpoint;
        private static CancellationTokenSource cts;

        private static readonly List<TcpClient> clients = new List<TcpClient>();

        public static void StartListeningForLoggerConnection()
        {
            if (isListening)
                return;

            isListening = true;
            Task.Run(ListenForLoggerConnections);
        }

        private static void ListenForLoggerConnections()
        {
            loggerEndpoint = TcpListener.Create(ServerConfig.logsPort);
            loggerEndpoint.Start();
            
            cts = new CancellationTokenSource();
            while (isListening)
            {
                try
                {
                    Logs.Message($"LoggerService is listening for connections on port {ServerConfig.logsPort}...");
                    
                    var acceptedClient = loggerEndpoint.AcceptTcpClientAsync();
                    acceptedClient.Wait(cts.Token);

                    var client = acceptedClient.Result;

                    lock (clients)
                          clients.Add(client);
                    
                    Logs.Message($"LoggerService: Remote logger connection accepted from {((IPEndPoint) client.Client.RemoteEndPoint).Address}");
                }
                catch (OperationCanceledException)
                {
                    Logs.Message("LoggerService: Logs endpoint closed.");
                    return;
                }
                catch (Exception e)
                {
                    Logs.Error($"LoggerService: Error occured on accepting logger client connection: {e}");
                }
            }
        }

        public static void Dispose()
        {
            if (!isListening)
                return;

            cts.Cancel();

            lock (clients)
                  clients.Clear();

            isListening = false;
            loggerEndpoint.Stop();
            loggerEndpoint = null;
        }

        private static async void FlushMessageToClients(string message, MessageType type)
        {
            if (clients.Count == 0)
                return;
            
            try
            {
                await Task.Run(() => FlushMessageTask(message, type));
            }
            catch (Exception e)
            {
                Logs.WriteDefaultLogs(e.ToString());
            }
        }

        private static void FlushMessageTask(string message, MessageType type)
        {
            byte[] messageBytes = GetMessageBytes(message, type).ToArray();

            lock (clients) for (int i = clients.Count - 1; i >= 0; i--)
            {
                if (clients[i].Connected)
                {
                    var stream = clients[i].GetStream();
                    stream.Write(messageBytes);
                }
                else
                {
                    Logs.Message($"LoggerService: Disconnecting client {((IPEndPoint) clients[i].Client.RemoteEndPoint).Address}");
                    clients[i].Close();
                    clients.RemoveAt(i);
                }
            }
        }

        private static IEnumerable<byte> GetMessageBytes(string message, MessageType type)
        {
            var typeByte      = Enumerable.Repeat((byte) type, 1);
            var messageBytes  = Encoding.ASCII.GetBytes(message);
            
            int messageLenght = sizeof(MessageType) /*1 byte*/ + messageBytes.Length;
            var lenghtBytes   = BitConverter.GetBytes(messageLenght);

            var bytes = lenghtBytes     // 4
                .Concat(typeByte)       // 1 
                .Concat(messageBytes);  // lenghtBytes

            return bytes;
        }

        public static void Message(string message)
        {
            FlushMessageToClients(message, MessageType.Message);
        }

        public static void Error(string message)
        {
            FlushMessageToClients(message, MessageType.Error);
        }

        public static void Warning(string message)
        {
            FlushMessageToClients(message, MessageType.Warning);
        }
    }
}