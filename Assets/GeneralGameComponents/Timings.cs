using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Debug = UnityEngine.Debug;

public struct Timing
{
    public string processName;
    public int ms;
    public override string ToString() => $"{processName}: {ms} ms";
}

public class Timings
{
    public List<Timing> timings = new List<Timing>();
    public override string ToString() => String.Join(",", timings.Select(val => val.ToString()).ToArray());

    public Timings Copy()
    {
        var res = new Timings();
        res.timings.AddRange(timings);
        return res;
    }
}

public class DelaysLogger
{
    static List<DelaysLogger>
        loggersPool = new List<DelaysLogger>(); // = new DelaysLogger("playfab API command waiting");

    static List<DelaysLogger> loggersInUse = new List<DelaysLogger>();

    public static DelaysLogger Get(string typeName = null)
    {
        DelaysLogger logger;
        if (loggersPool.Count > 0)
        {
            logger = loggersPool[loggersPool.Count -1];
            loggersPool.RemoveAt(loggersPool.Count -1);
            logger.typeName = typeName;
            logger.writesLog = () => false;
        }
        else
            logger = new DelaysLogger(typeName, () => false);

        loggersInUse.Add(logger);
        return logger;
    }

    public static void Return(DelaysLogger logger)
    {
        logger.timings.timings.Clear();
        loggersInUse.Remove(logger);
        loggersPool.Add(logger);
    }

    public static void UpdateInUse() => loggersInUse.ForEach(logger => logger.Update());

    public Timings timings { get; private set; } = new Timings();
    public void AddTiming(Timing timing) => timings.timings.Add(timing);
    public void AddTimings(Timings timings) => timings.timings.AddRange(timings.timings);
    Func<bool> writesLog;
    string typeName;

    public DelaysLogger(string typeName, Func<bool> writesLog)
    {
        this.typeName = typeName;
        this.writesLog = writesLog;
    }

    string processName;
    Stopwatch sw = new Stopwatch();

    public void OnBeforeStart(string processName)
    {
        sw.Restart();
        this.processName = processName;
        waitingWarningWritten = false;
    }

    public Timing OnAfterFinish(Timings additionalTimings = null)
    {
        sw.Stop();
        Timing timing = new Timing { processName = processName, ms = (int)sw.ElapsedMilliseconds };
        if (writesLog())
            Debug.Log($"{typeName} ({timing.processName}) duration = {timing.ms} ms\n{additionalTimings?.ToString()}");
        timings.timings.Add(timing);
        return timing;
    }

    public Timing OnAfterFinishBeforeNew(string newProcessName)
    {
        var timing = OnAfterFinish();
        OnBeforeStart(newProcessName);
        return timing;
    }

    const long WaitingThreshold = 5000; // 5 sec.
    bool waitingWarningWritten;

    public void Update()
    {
        if (sw.ElapsedTicks > WaitingThreshold && !waitingWarningWritten)
        {
            waitingWarningWritten = true;
            Debug.Log($"{typeName} ({processName}) not finished in {WaitingThreshold} ms");
        }
    }
}
#if CLIENT
    public static class DelaysLoggerClientMeta
    {
        static DelaysLogger logger =
 new DelaysLogger("client meta command waiting", () => false); // Dont write detailed logs so far.
        public static void OnBeforeSend(RemoteMetaRequestType type)=>logger.OnBeforeStart(type.ToString());
        public static int OnAfterReceived(RemoteMetaResponse response) => logger.OnAfterFinish(response.timings).ms;
        public static void Update() => logger.Update();
    }
    public static class DelaysLoggerClientBattle
    {
        public static void OnBeforeSend<ResponseType>(Command command, IBattleNetworkClient network) where ResponseType : Command
        {
            DelaysLogger logger = DelaysLogger.Get("battle command waiting");
            var responseType = typeof(ResponseType);
            logger.OnBeforeStart($"{command.GetType().Name}->{responseType.Name}");
            network.SubscribeOnce<ResponseType>(response=> {
                logger.OnAfterFinish(response.timings);
                DelaysLogger.Return(logger);
            });
        }
    }
#endif

#if SERVER
#endif

// public static class DelaysLoggerPlayfab
// {
//     public static DelaysLogger OnBeforeSend(PlayFabRequestCommon request)
//     {
//         DelaysLogger logger = DelaysLogger.Get();
//         logger.OnBeforeStart(request.GetType().Name);
//         return logger;
//     }
//
//     public static Timing OnAfterReceived(DelaysLogger logger)
//     {
//         Timing timing = logger.OnAfterFinish();
//         DelaysLogger.Return(logger);
//         return timing;
//     }
// }