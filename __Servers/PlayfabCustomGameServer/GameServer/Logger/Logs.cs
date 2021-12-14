namespace GameServer.Logging
{
    using System;
    using Microsoft.Playfab.Gaming.GSDK.CSharp;
    
    public static class Logs
    {
        public static void Message(string message)
        {
            try
            {
                WriteDefaultLogs(message);
                LoggerService.Message(message);
            }
            catch
            {
                // ignore general cases when called thread interrupted or aborted and cant access resources
            }
        }

        public static void Error(string message)
        {
            try
            {
                WriteDefaultLogs(message);
                LoggerService.Error(message);
            }
            catch
            {
                // ignore general cases when called thread interrupted or aborted and cant access resources
            }
        }

        public static void Warning(string message)
        {
            try
            {
                WriteDefaultLogs(message);
                LoggerService.Warning(message);
            }
            catch
            {
                // ignore general cases when called thread interrupted or aborted and cant access resources
            }
        }

        public static void WriteDefaultLogs(string message)
        {
            if (ServerConstants.USE_PLAYFAB)
                GameserverSDK.LogMessage(message);
            
            Console.WriteLine(message);
        }
    }
}