namespace GameServer.Logging
{
    using System;
    using System.Net;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using Mirror.SimpleWeb;
    using System.Net.Sockets;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    public static class LoggerService
    {
        private static bool isSending;
        private static bool isListening;
        private static TcpListener loggerEndpoint;
        private static CancellationTokenSource cts;

        private static readonly List<TcpClient> clients = new List<TcpClient>();
        private static readonly ConcurrentQueue<ArrayBuffer> messages = new ConcurrentQueue<ArrayBuffer>();
        private static readonly BufferPool bufferPool = new BufferPool(
            bucketCount: 5, 
            ServerConstants.LG_MIN_MESSAGE_SIZE, 
            ServerConstants.LG_MAX_MESSAGE_SIZE);

        public static void StartListeningForLoggerConnection()
        {
            if (isListening)
                return;

            isListening = true;
            new Thread(ListenForLoggerConnections).Start();
            
            isSending = true;
            new Thread(FlushMessagesRoutine).Start();
        }

        private static void ListenForLoggerConnections()
        {
            try
            {
                loggerEndpoint = TcpListener.Create(ServerConfig.logsPort);
                loggerEndpoint.ExclusiveAddressUse = true;
                loggerEndpoint.Start();

                cts = new CancellationTokenSource();

                while (isListening)
                {
                    Logs.Message($"LoggerService is listening for connections on port {ServerConfig.logsPort}...");

                    var acceptedClient = loggerEndpoint.AcceptTcpClientAsync();
                    acceptedClient.Wait(cts.Token);

                    var client = acceptedClient.Result;

                    lock (clients)
                          clients.Add(client);

                    Logs.Message($"LoggerService: Remote logger connection accepted from {((IPEndPoint) client.Client.RemoteEndPoint).Address}");
                }
            }
            catch (OperationCanceledException)
            {
                Logs.Message("LoggerService: Logs endpoint closed.");
            }
            catch (Exception e)
            {
                Logs.Error($"LoggerService: Error occured on accepting logger client connection: {e}");
            }
        }

        private static void FlushMessagesRoutine()
        {
            while (isSending)
            {
                FlushMessages();
                Thread.Sleep(ServerConstants.LG_SEND_PERIOD);
            }
        }

        private static void FlushMessages()
        {
            try
            {
                int processedCount = 0;
                while (
                    processedCount < ServerConstants.LG_MAX_MESSAGES_PER_TICK &&
                    messages.TryDequeue(out ArrayBuffer next))
                {
                    processedCount++;

                    lock (clients) for (int i = clients.Count - 1; i >= 0; i--)
                    {
                        if (clients[i].Connected)
                        {
                            var stream = clients[i].GetStream();
                            stream.Write(next.ToSegment());
                            next.Release();
                        }
                        else
                        {
                            Logs.Message($"LoggerService: Disconnecting client {((IPEndPoint) clients[i].Client.RemoteEndPoint).Address}");
                            clients[i].Close();
                            clients.RemoveAt(i);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logs.WriteDefaultLogs($"LoggerService: SendMessagesRoutine encounter an exception: {e}");
            }
        }

        private static void QueueMessage(string message, MessageType type)
        {
            var bytes = GetMessageBytes(message, type).ToArray();

            Mirror.SimpleWeb.Log.StartNoLog();
            var buffer = bufferPool.Take(bytes.Length);
            Mirror.SimpleWeb.Log.EndNoLog();

            buffer.CopyFrom(new ArraySegment<byte>(bytes));
            messages.Enqueue(buffer);
        }
        
        private static IEnumerable<byte> GetMessageBytes(string message, MessageType type)
        {
            var typeByte      = Enumerable.Repeat((byte) type, 1);
            var messageBytes  = Encoding.ASCII.GetBytes(message);
            
            int messageLenght = sizeof(MessageType) /*1 byte*/ + messageBytes.Length;
            var lenghtBytes   = BitConverter.GetBytes(messageLenght);

            var bytes = lenghtBytes            // 4
                        .Concat(typeByte)      // 1 
                        .Concat(messageBytes); // lenghtBytes

            return bytes;
        }

        public static void Message(string message)
        {
            QueueMessage(message, MessageType.Message);
        }

        public static void Error(string message)
        {
            QueueMessage(message, MessageType.Error);
        }

        public static void Warning(string message)
        {
            QueueMessage(message, MessageType.Warning);
        }
        
        public static void Dispose()
        {
            Logs.Message("LoggerService: Disposing service...");
            
            if (!isListening)
                return;

            cts.Cancel();

            lock (clients)
                  clients.Clear();
            
            isListening = false;
            isSending = false;
            loggerEndpoint.Stop();
            loggerEndpoint = null;
            
            messages.Clear();
            
            Logs.Message("LoggerService: Disposed.");
        }
    }
}