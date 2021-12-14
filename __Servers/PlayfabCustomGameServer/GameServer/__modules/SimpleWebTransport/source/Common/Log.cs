using System;
using Conditional = System.Diagnostics.ConditionalAttribute;

namespace Mirror.SimpleWeb
{
    public static class Log
    {
        private static Action<string> _logMessage;
        private static Action<string> _logWarning;
        private static Action<string> _logError;

        public static void SetLogHandlers(
            Action<string> logMessage, 
            Action<string> logWarning, 
            Action<string> logError)
        {
            _logMessage = logMessage;
            _logWarning = logWarning;
            _logError   = logError;
        }
        
        // used for Conditional
        const string SIMPLEWEB_LOG_ENABLED = nameof(SIMPLEWEB_LOG_ENABLED);
        const string DEBUG = nameof(DEBUG);

        public enum Levels
        {
            none = 0,
            error = 1,
            warn = 2,
            info = 3,
            verbose = 4,
        }
        
        public static Levels level = Levels.none;
        
        private static Levels __oldLevel;
        public static void StartNoLog()
        {
            __oldLevel = level;
            level = Levels.none;
        }
        public static void EndNoLog()
        {
            level = __oldLevel;
        }

        public static string BufferToString(byte[] buffer, int offset = 0, int? length = null)
        {
            return BitConverter.ToString(buffer, offset, length ?? buffer.Length);
        }

        [Conditional(SIMPLEWEB_LOG_ENABLED)]
        public static void DumpBuffer(string label, byte[] buffer, int offset, int length)
        {
            if (level < Levels.verbose)
                return;

            _logMessage?.Invoke($"VERBOSE: <color=blue>{label}: {BufferToString(buffer, offset, length)}</color>");
        }

        [Conditional(SIMPLEWEB_LOG_ENABLED)]
        public static void DumpBuffer(string label, ArrayBuffer arrayBuffer)
        {
            if (level < Levels.verbose)
                return;

            _logMessage?.Invoke($"VERBOSE: <color=blue>{label}: {BufferToString(arrayBuffer.array, 0, arrayBuffer.count)}</color>");
        }

        [Conditional(SIMPLEWEB_LOG_ENABLED)]
        public static void Verbose(string msg, bool showColor = true)
        {
            if (level < Levels.verbose)
                return;

            if (showColor)
                _logMessage?.Invoke($"VERBOSE: <color=blue>{msg}</color>");
            else
                _logMessage?.Invoke($"VERBOSE: {msg}");
        }

        [Conditional(SIMPLEWEB_LOG_ENABLED)]
        public static void Info(string msg, bool showColor = true)
        {
            if (level < Levels.info)
                return;

            if (showColor)
                _logMessage?.Invoke($"INFO: <color=blue>{msg}</color>");
            else
                _logMessage?.Invoke($"INFO: {msg}");
        }

        /// <summary>
        /// An expected Exception was caught, useful for debugging but not important
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="showColor"></param>
        [Conditional(SIMPLEWEB_LOG_ENABLED)]
        public static void InfoException(Exception e)
        {
            if (level < Levels.info)
                return;

            _logMessage?.Invoke($"INFO_EXCEPTION: <color=blue>{e.GetType().Name}</color> Message: {e.Message}");
        }

        [Conditional(SIMPLEWEB_LOG_ENABLED), Conditional(DEBUG)]
        public static void Warn(string msg, bool showColor = true)
        {
            if (level < Levels.warn)
                return;

            if (showColor)
                _logWarning?.Invoke($"WARN: <color=orange>{msg}</color>");
            else
                _logWarning?.Invoke($"WARN: {msg}");
        }

        [Conditional(SIMPLEWEB_LOG_ENABLED), Conditional(DEBUG)]
        public static void Error(string msg, bool showColor = true)
        {
            if (level < Levels.error)
                return;

            if (showColor)
                _logError?.Invoke($"ERROR: <color=red>{msg}</color>");
            else
                _logError?.Invoke($"ERROR: {msg}");
        }

        public static void Exception(Exception e)
        {
            // always log Exceptions
            _logError?.Invoke($"EXCEPTION: <color=red>{e.GetType().Name}</color> Message: {e.Message}");
        }
    }
}
