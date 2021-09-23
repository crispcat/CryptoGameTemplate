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
    }
}