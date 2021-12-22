using System;
using ZergRush.CodeGen;

namespace Game
{
    [GenSerialization]
    public partial struct ShortPlayerInfo
    {
        [CanBeNull] public string displayName;
        public int level;
    }
    
    public enum AuthType
    {
        DeviceID,
        EmailPassword,
        GameCenter,
        GooglePlay,
        FaceBook,
    }

    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization)]
    public partial class AuthData
    {
        [CanBeNull] public string email;
        [CanBeNull] public string password;
        [CanBeNull] public string authId;
        [CanBeNull] public string facebookId;
        [CanBeNull] public string gamecenterId;
        [CanBeNull] public string googleId;
        
        public AuthType type = AuthType.EmailPassword;
        
        public static string GetAuthIdFromCommandLine()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();
            for (int i = 0; i < commandLineArgs.Length; i++)
            {
                if (commandLineArgs[i] == "playerAuthId")
                    return commandLineArgs[i + 1];
            }
            //Debug.LogError("playerAuthId should be set in command line args");
            return string.Empty;
        }

        public AuthData MakeCopy()
        {
            return new AuthData
            {
                authId = authId,
                facebookId = facebookId,
                gamecenterId = gamecenterId,
                googleId = googleId,
                
                type = type
            };
        }

        public AuthData MakeCopy(AuthType authType)
        {
            var copy = MakeCopy();
            copy.type = authType;
            return copy;
        }

        public string GetCurrentID()
        {
            switch (type)
            {
                case AuthType.DeviceID:
                    return authId;
                case AuthType.GameCenter:
                    return gamecenterId;
                case AuthType.GooglePlay:
                    return googleId;
                case AuthType.FaceBook:
                    return facebookId;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}