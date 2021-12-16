namespace AGameServer.Logging
{
    using System;
    using Microsoft.Playfab.Gaming.GSDK.CSharp;

    using static AGameServer;

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
            if (ServerConfig.PROVIDER == HostingProvider.Playfab)
                GameserverSDK.LogMessage(message);
            
            Console.WriteLine(message);
        }

        #region SafeInvokes

        public static Action SafeInvoke(Action action)
        {
            return () =>
            {
                try
                {
                    action();
                }
                catch (Exception e)
                {
                    Error(e.ToString());
                    throw;
                }
            };
        }
        
        public static Action<T> SafeInvoke<T>(Action<T> action)
        {
            return (arg) =>
            {
                try
                {
                    action(arg);
                }
                catch (Exception e)
                {
                    Error(e.ToString());
                    throw;
                }
            };
        }
        
        public static Action<T1, T2> SafeInvoke<T1, T2>(Action<T1, T2> action)
        {
            return (a1, a2) =>
            {
                try
                {
                    action(a1, a2);
                }
                catch (Exception e)
                {
                    Error(e.ToString());
                    throw;
                }
            };
        }
        
        #endregion
    }
}