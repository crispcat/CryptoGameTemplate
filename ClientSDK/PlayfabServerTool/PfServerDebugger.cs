#if UNITY_EDITOR
namespace PlayFabServerTool
{
    using System;
    using System.IO;
    using System.Text;
    using UnityEditor;
    using UnityEngine;
    using System.Threading;
    using System.Net.Sockets;
    
    public static class PfServerDebugger
    {
        private const ushort RECONNECT_RST_ATTEMPTS = 1;
        
        private static bool _isConnected;

        public static void Connect(string ip, int port)
        {
            var recieveLogThread = new Thread(() => ReceiveMessages(ip, port));
            recieveLogThread.Start();
        }

        private static void ReceiveMessages(string ip, int port, ushort reconnectAttempts = 0)
        {
            ip = ip.Trim();

            _isConnected = true;

            using var tcpClient = new TcpClient();

            tcpClient.Connect(ip, port);
            var stream = tcpClient.GetStream();

            Debug.Log($"Logger service status: ip: {ip}, port: {port}, connected: {tcpClient.Connected}, bytes available: {tcpClient.Available}");

            while (_isConnected)
            {
                try
                {
                    // first 4 bytes is message lenght : message type (1 byte) + string data ([0, int.MaxValue] bytes)
                    byte[] lenghtBytes = new byte[4];
                    stream.Read(lenghtBytes, 0, 4);
                    int messageLenght = BitConverter.ToInt32(lenghtBytes, 0);

                    // next byte is message type
                    byte[] messageTypeBytes = new byte[1];
                    stream.Read(messageTypeBytes, 0, 1);
                    var messageType = messageTypeBytes[0];

                    // everything else is message string
                    byte[] messageBytes = new byte[messageLenght - 1];
                    stream.Read(messageBytes, 0, messageLenght - 1);
                    var message = Encoding.ASCII.GetString(messageBytes);
                    var logMessage = $"{ip}:{port} :: {message}";

                    switch (messageType)
                    {
                        case 0:
                            Debug.Log(logMessage);
                            break;
                        case 1:
                            Debug.LogError(logMessage);
                            break;
                        case 2:
                            Debug.LogWarning(logMessage);
                            break;

                        default:
                            Debug.LogError("PfServerDebugger: Unknown message type provided by server logger.");
                            break;
                    }

                    reconnectAttempts = 0;
                }
                catch (IOException e)
                {
                    Debug.Log("PfServerDebugger: server possibly going to stand by.");
                    
                    if (reconnectAttempts > RECONNECT_RST_ATTEMPTS)
                    {
                        Debug.LogError($"PfServerDebugger: encounters an {e}");
                        return;
                    }

                    Debug.Log($"PfServerDebugger: encounters an {e}.");
                    Debug.Log($"Trying to reconnect {++reconnectAttempts}. Max attempts: {RECONNECT_RST_ATTEMPTS}");
                    ReceiveMessages(ip, port, reconnectAttempts: 1);
                }
            }
        }

        [MenuItem("ServerLogger/Disconnect")]
        public static void Disconnect()
        {
            _isConnected = false;
            Debug.Log("All loggers disconnected.");
        }
    }
}
#endif