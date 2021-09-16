using System;

namespace Game
{
    public static class SystemLayer
    {
        public static long ticks => DateTime.UtcNow.Ticks;
    }
}