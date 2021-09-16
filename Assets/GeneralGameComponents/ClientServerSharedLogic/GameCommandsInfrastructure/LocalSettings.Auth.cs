using System.Collections;
using System.Collections.Generic;
using Game;
using Newtonsoft.Json;
using UnityEngine;

namespace GameTools
{
    public partial class LocalSettings
    {
        public AuthData authData;
        public ulong lastRemotePlayerModelHash;
        public bool logRemoteGameMetaCommands;
        
        public void WriteJsonFields(JsonTextWriter writer)
        {
            throw new System.NotImplementedException();
        }

        public void ReadFromJsonField(JsonTextReader reader, string name)
        {
            throw new System.NotImplementedException();
        }
    }
}