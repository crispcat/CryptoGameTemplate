using System;
using System.IO;
using Newtonsoft.Json;
using ClientServerSharedLogic;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // test server build with unity.dll, newtonsoft assemblies and ZergRush referenced from client project
            
            var sw = new StringWriter();
            var jsonWriter = new JsonTextWriter(sw);
            var playerPos = new PlayerPositionData(5, 5, 5);
            
            playerPos.WriteJson(jsonWriter);
            jsonWriter.Flush();
            
            Console.WriteLine(sw.ToString());
            Console.ReadKey();
        }
    }
}