using System.Runtime.InteropServices;
using UnityEngine;

namespace CGT
{
    public static class SystemLoadCounters
    {
        [DllImport("WindowsSystemLoad")]
        static extern float GetCPULoad();

        [DllImport("WindowsSystemLoad")]
        static extern float GetMemoryLoad();

        const float UpdateDuration = 10; // sec.
        static float prevTimeUpdateTime;

        /// <summary>
        /// %, all cpus
        /// </summary>
        public static float CPULoad { get; private set; }
        /// <summary>
        /// mb for this process
        /// </summary>
        public static float MemoryLoad { get; private set; }

        public static void UnityFrameUpdate()
        {
            if (prevTimeUpdateTime + UpdateDuration > Time.realtimeSinceStartup)
                return;
            prevTimeUpdateTime = Time.realtimeSinceStartup;
            CPULoad = GetCPULoad() * 100;
            MemoryLoad = GetMemoryLoad();
        }
    }
}