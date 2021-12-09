using System;
using UnityEngine;
using Mirror.SimpleWeb;
using PlayFabServerTool;

public class WssTestClient : MonoBehaviour
{
    [Header("Endpoint")]
    public string endpontIp;
    public int endpontPort;
    
    #if UNITY_EDITOR
    [Space]
    [Header("Debugger")]
    public string debuggerIp;
    public int debuggerPort;
    #endif

    [Space]
    [Header("Client options")]
    
    public int maxMessageSize      = 16 * 1024;
    public int maxMessagesPerTick  = 1000;
    public int sendTimeout         = 5000;
    public int receiveTimeout      = 20000;
    public bool noDelay            = true;

    [Space]

    private SimpleWebClient wssClient;

    private void Start()
    {
        #if UNITY_EDITOR
        PfServerDebugger.Connect(debuggerIp, debuggerPort); 
        #endif
        
        Log.level = Log.Levels.verbose;
        
        wssClient = SimpleWebClient.Create(
            maxMessageSize, 
            maxMessagesPerTick, 
            new TcpConfig(
                noDelay, 
                sendTimeout, 
                receiveTimeout));
        
        wssClient.Connect(new Uri($"http://{endpontIp}:{endpontPort}"));
    }

    private void Update()
    {
        wssClient.ProcessMessageQueue(this);
    }
}
