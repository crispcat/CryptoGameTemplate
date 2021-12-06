using System;
using System.Text;
using UnityEditor;
using UnityEngine;
using System.Threading;
using System.Net.Sockets;

namespace PlayFabServerTool
{
    public static class PfServerDebugger
    {
        private static bool _isConnected;
        
        private static string _ip;
        private static int _port;

        public static void Connect(string ip, int port)
        {
            _ip = ip;
            _port = port;
            
            var recieveLogThread = new Thread(ReceiveMessage);
            recieveLogThread.Start();
        }

        private static void ReceiveMessage()
        {
            _isConnected = true;

            using var tcpClient = new TcpClient();
            
            tcpClient.Connect(_ip, _port);
            var stream = tcpClient.GetStream();
            
            Debug.Log($"Logger service status: ip: {_ip}, port: {_port}, connected: {tcpClient.Connected}, bytes available: {tcpClient.Available}");
            
            while (_isConnected)
            {
                byte[] lenghtBytes = new byte[4];
                byte[] messageTypeBytes = new byte[1];
                
                stream.Read(lenghtBytes, 0, 4);
                
                int messageLenght = BitConverter.ToInt32(lenghtBytes, 0);
                byte[] messageBytes = new byte[messageLenght - 1];

                stream.Read(messageTypeBytes, 0, 1);
                var messageType = messageBytes[0];

                stream.Read(messageBytes, 0, messageLenght - 1);
                var messge = Encoding.ASCII.GetString(messageBytes);
                
                Debug.Log(messge);
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