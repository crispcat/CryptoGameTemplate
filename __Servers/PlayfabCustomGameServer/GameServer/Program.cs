using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using ClientServerSharedLogic;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // test build with unity and 3rd party assemblies referenced from main project
            
            var sw = new StringWriter();
            var jsonWriter = new JsonTextWriter(sw);
            var playerPos = new PlayerPositionData(new Vector3(5, 5, 5));
            
            playerPos.WriteJson(jsonWriter);
            jsonWriter.Flush();
            
            Console.WriteLine(sw.ToString());
        }
    }
}