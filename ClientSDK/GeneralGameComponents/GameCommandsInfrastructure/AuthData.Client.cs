using System;
using UnityEngine;

namespace CGT
{
    public partial class AuthData
    {
        public static AuthData Default()
        {
            return new AuthData { authId = DefaultPlayerAuthId(), type = AuthType.DeviceID};
        }
        static string DefaultPlayerAuthId()
        {
            string id;
            if (Application.isMobilePlatform)
                id = SystemInfo.deviceUniqueIdentifier;
            else if (Application.isEditor)
                id = Guid.NewGuid().ToString();
            else
                id = GetAuthIdFromCommandLine();
            return id;
        }
    }
}