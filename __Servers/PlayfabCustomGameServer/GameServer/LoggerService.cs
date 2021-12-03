using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Microsoft.Playfab.Gaming.GSDK.CSharp;

namespace GameServer.Logging
{
    public static class Logs
    {
        public static void Message(string message)
        {
            WriteDefaultLogs(message);
            LoggerService.Message(message);
        }

        public static void Error(string message)
        {
            WriteDefaultLogs(message);
            LoggerService.Error(message);
        }

        public static void Warning(string message)
        {
            WriteDefaultLogs(message);
            LoggerService.Warning(message);
        }

        private static void WriteDefaultLogs(string message)
        {
            GameserverSDK.LogMessage(message);
            Console.WriteLine(message);
        }
    }
    
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
                    Logs.Message("LoggerService is listening for connections...");
                    
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

        private enum MessageType : byte
        {
            Message = 0,
            Error   = 1,
            Warning = 2
        }

        private static void FlushMessageToClients(string message, MessageType type)
        {
            lock (clients)
            {
                if (clients.Count == 0)
                    return;

                byte[] messageBytes = GetMessageBytes(message, type).ToArray();
                
                for (int i = clients.Count; i >= 0; i--)
                {
                    if (clients[i].Connected)
                    {
                        var stream = clients[i].GetStream();
                        stream.WriteAsync(messageBytes);
                    }
                    else
                    {
                        clients[i].Close();
                        clients.RemoveAt(i);
                    }
                }
            }
        }

        private static IEnumerable<byte> GetMessageBytes(string message, MessageType type)
        {
            var messageBytes = Encoding.ASCII.GetBytes(message);
            var messageLenght = (uint) (sizeof(uint) + sizeof(MessageType) + messageBytes.Length);

            var lenghtBytes = BitConverter.GetBytes(messageLenght);
            var typeByte    = Enumerable.Repeat((byte) type, 1);

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