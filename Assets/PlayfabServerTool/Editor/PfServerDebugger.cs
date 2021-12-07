﻿using System;
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

        public static void Connect(string ip, int port)
        {
            var recieveLogThread = new Thread(() => ReceiveMessage(ip, port));
            recieveLogThread.Start();
        }

        private static void ReceiveMessage(string ip, int port)
        {
            ip = ip.Trim();

            _isConnected = true;

            using var tcpClient = new TcpClient();
            
            tcpClient.Connect(ip, port);
            var stream = tcpClient.GetStream();
            
            Debug.Log($"Logger service status: ip: {ip}, port: {port}, connected: {tcpClient.Connected}, bytes available: {tcpClient.Available}");
            
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
                var message = Encoding.ASCII.GetString(messageBytes);
                var logMessage = $"{ip}:{port} :: {message}";

                switch (messageType)
                {
                    case 0 : 
                        Debug.Log(logMessage); 
                        break;
                    case 1 : 
                        Debug.LogError(logMessage); 
                        break;
                    case 2 : 
                        Debug.LogWarning(logMessage); 
                        break;
                    
                    default :
                        Debug.LogError("PfServerDebugger: Unknown message type provided by server logger.");
                        break;
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