// using System;
// using System.Net.Sockets;
// using System.Text;
// using System.Threading;
// using System.Threading.Tasks;
// using PlayFab;
// using PlayFab.AdminModels;
// using PlayFab.ClientModels;
// using UnityEditor;
// using UnityEngine;
//
// #if UNITY_EDITOR
// namespace ServerLoggerClient
// {
//     public static class LoggerClient
//     {
//         private const string buildId = "e92dca6d-df92-49f9-99c5-1edb119125aa";
//         
//         private static string ip;
//         private static int port;
//         private static bool isConnected = false;
//
//         [MenuItem("ServerLogger/ConnectToServer")]
//         public static async void ConnectToServer()
//         {
//             var request = new LoginWithCustomIDRequest {CustomId = "developer", CreateAccount = true};
//             await PlayFabClientAPIAsync.LoginWithCustomID(request);
//
//             PlayFab.Internal.PlayFabWebRequest.SkipCertificateValidation();
//             var builds = await PlayFabAdminAPIAsync.ListServerBuilds(new ListBuildsRequest());
//             
//             Debug.Log(builds.Result.ToJson());
//         }
//
//         private static void ReceiveMessage()
//         {
//             isConnected = true;
//
//             using var tcpClient = new TcpClient(ip, port);
//             var stream = tcpClient.GetStream();
//             
//             while (isConnected)
//             {
//                 byte[] lenghtBytes = new byte[4];
//                 byte[] messageTypeBytes = new byte[1];
//                 
//                 stream.Read(lenghtBytes, 0, 4);
//                 
//                 int messageLenght = BitConverter.ToInt32(lenghtBytes, 0);
//                 byte[] messageBytes = new byte[messageLenght - 1];
//
//                 stream.Read(messageTypeBytes, 0, 1);
//                 var messageType = messageBytes[0];
//
//                 stream.Read(messageBytes, 0, messageLenght - 1);
//                 var messge = Encoding.ASCII.GetString(messageBytes);
//                 
//                 Debug.Log(messge);
//             }
//         }
//
//         [MenuItem("ServerLogger/Disconnect")]
//         public static void Disconnect()
//         {
//             isConnected = false;
//         }
//     }
// }
// #endif