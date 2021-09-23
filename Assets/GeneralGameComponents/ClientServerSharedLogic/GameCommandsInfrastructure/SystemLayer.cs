using System;

namespace Game
{
    public static class SystemLayer
    {
        public static long ticks => DateTime.UtcNow.Ticks;

        public static void Log(string message)
        {
            
        }
        public static void LogError(string message)
        {
            
        }
    }
}