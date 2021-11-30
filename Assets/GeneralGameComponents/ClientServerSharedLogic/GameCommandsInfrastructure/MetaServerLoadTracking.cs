using System;
using System.Collections.Generic;
using UnityEngine;
using ZergRush;

namespace Game
{
    public class MetaServerLoadTracking
    {
        #region What to track
        public void UpdateSessionsCount(int count) => AddValue(TrackedParams.SessionsCount, count);
        public void OnSessionFinished(float elapsed) => AddValue(TrackedParams.SessionDuration, elapsed);
        public static void OnLocalCommandsExecuted(int count) => instance?.AddValue(TrackedParams.LocalCommands, count);
        public static void OnRemoteCommandExecuted() => instance?.AddValue(TrackedParams.RemoteCommands, 1);
        public static void OnServerAPICall() => instance?.AddServerAPICall();
        #endregion

        #region Server api calls per 10 sec 
        const float APICallsPer = 10; // sec.
        LinkedList<float> apiCalls = new LinkedList<float>();
        private void AddServerAPICall()
        {
            apiCalls.AddLast(Time.realtimeSinceStartup);
        }
        void UpdateServerAPICalls()
        {
            while (apiCalls.First != null && apiCalls.First.Value + APICallsPer < Time.realtimeSinceStartup)
                apiCalls.RemoveFirst();
            AddValue(TrackedParams.ServerAPICallPer10Sec, apiCalls.Count);
        }
        #endregion

        void UpdateSystemParams()
        {
            AddValue(TrackedParams.Memory, SystemLoadCounters.MemoryLoad);
            AddValue(TrackedParams.CPU, SystemLoadCounters.CPULoad);
        }

        #region How to track
        enum TrackedParams
        {
            CPU,
            Memory,            
            LocalCommands,
            RemoteCommands,
            ServerAPICallPer10Sec,
            SessionsCount,
            SessionDuration
        }
        enum AggregationType
        {
            Mean,
            Max,
            Sum
        }
        private (AggregationType aggregation, string dimension) GetTrackingSettings(TrackedParams type)
        {
            switch (type)
            {
                default: throw new GameException();
                case TrackedParams.SessionDuration: return (AggregationType.Mean, "s");
                case TrackedParams.SessionsCount: return (AggregationType.Mean, "");
                case TrackedParams.RemoteCommands: return (AggregationType.Sum, "");
                case TrackedParams.LocalCommands: return (AggregationType.Sum, "");
                case TrackedParams.Memory: return (AggregationType.Max, "MB");
                case TrackedParams.CPU: return (AggregationType.Max, "%");
                case TrackedParams.ServerAPICallPer10Sec: return (AggregationType.Max, "/1000");
            }
        }
        public void Update()
        {
            UpdateServerAPICalls();
            UpdateSystemParams();
            SystemLoadCounters.UnityFrameUpdate();
            UpdateAggregation();
        }
        private static MetaServerLoadTracking instance;
        Dictionary<TrackedParams, AggregatedParam> trackedParams;
        public MetaServerLoadTracking()
        {
            instance = this;
            Debug.Log($"cpu is {SystemInfo.processorType} ({SystemInfo.processorFrequency}MHz x {SystemInfo.processorCount}), " +
                      $"ram is {SystemInfo.systemMemorySize}MB");

            trackedParams = new Dictionary<TrackedParams, AggregatedParam>();
            foreach (TrackedParams type in Enum.GetValues(typeof(TrackedParams)))
            {
                var (aggregation, dimension) = GetTrackingSettings(type);
                AggregatedParam param = null;
                switch (aggregation)
                {
                    case AggregationType.Max: param = new MaxParam(dimension); break;
                    case AggregationType.Mean: param = new MeanParam(dimension); break;
                    case AggregationType.Sum: param = new SumParam(dimension); break;
                }
                trackedParams.Add(type, param);
            }
            prevAggregationTime = Time.realtimeSinceStartup;
            prevAggregationUtc = DateTime.UtcNow;
        }
        private void AddValue(TrackedParams type, float value) => trackedParams[type].OnParamValueReceived(value);
        float prevAggregationTime;
        DateTime prevAggregationUtc;
        public const float Period = 10;
        bool dropAggregationItsFirst = true;
        int periodInd;
        void UpdateAggregation()
        {
            if (prevAggregationTime + Period > Time.realtimeSinceStartup)
                return;
            var now = DateTime.UtcNow;
            if (!dropAggregationItsFirst)
            {
                periodInd++;
                Debug.Log($"\nLOAD TEST report for {Period}s from {prevAggregationUtc.ToString()} to {now.ToString()}, total {periodInd} periods = {periodInd * Period}s:\n" +
                          $"CPU={trackedParams[TrackedParams.CPU].Log()}\n" +
                          $"Memory={trackedParams[TrackedParams.Memory].Log()}\n" +
                          $"LocalCommands={trackedParams[TrackedParams.LocalCommands].Log()}\n" +
                          $"RemoteCommands={trackedParams[TrackedParams.RemoteCommands].Log()}\n" +
                          $"ServerAPICallPer10Sec={trackedParams[TrackedParams.ServerAPICallPer10Sec].Log()}\n" +
                          $"SessionsCount={trackedParams[TrackedParams.SessionsCount].Log()}\n" +
                          $"SessionDuration={trackedParams[TrackedParams.SessionDuration].Log()}\n" +
                          $"");
                GC.Collect(); // Just to test.
            }
            else
            {
                dropAggregationItsFirst = false;
                trackedParams.ForEach(item => item.Value.Reset());
            }
            prevAggregationTime = Time.realtimeSinceStartup;
            prevAggregationUtc = now;
            trackedParams.ForEach(item => item.Value.Aggregate());
        }        
        #endregion

    }
}