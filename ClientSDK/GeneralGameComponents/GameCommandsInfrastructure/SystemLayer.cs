using System;
using UnityEngine;

namespace CGT
{
    public static class SystemLayer
    {
        public static long ticks => DateTime.UtcNow.Ticks;

        public static void Log(string message)
        {
            Debug.Log(message);
        }
        public static void LogError(string message)
        {
            Debug.LogError(message);
        }
    }
}