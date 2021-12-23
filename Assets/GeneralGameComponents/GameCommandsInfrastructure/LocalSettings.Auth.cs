using System.Collections;
using System.Collections.Generic;
using CGT;
using Newtonsoft.Json;
using UnityEngine;

namespace CGT
{
    public partial class LocalSettings
    {
        public AuthData authData;
        public ulong lastRemoteGameModelHash;
        public bool logRemoteGameMetaCommands;
    }
}