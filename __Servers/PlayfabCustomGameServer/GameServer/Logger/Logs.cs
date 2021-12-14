namespace GameServer.Logging
{
    using System;
    using Microsoft.Playfab.Gaming.GSDK.CSharp;
    
    public static class Logs
    {
        public static void Message(string message)
        {
            WriteDefaultLogs(message);
            LoggerService.Message(message);
        }

        public static void Error(string message)
        {
            WriteDefaultLogs(message);
            LoggerService.Error(message);
        }

        public static void Warning(string message)
        {
            WriteDefaultLogs(message);
            LoggerService.Warning(message);
        }

        public static void WriteDefaultLogs(string message)
        {
            Console.WriteLine(message);
            if (ServerConstants.USE_PLAYFAB)
                GameserverSDK.LogMessage(message);
        }
    }
}