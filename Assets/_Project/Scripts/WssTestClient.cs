using System;
using System.Collections;
using ClientServerSharedLogic;
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
    public int sendTimeout         = 7_000;
    public int receiveTimeout      = int.MaxValue;
    public bool noDelay            = true;

    [Space]

    private SimpleWebClient wssClient;

    private void Start()
    {
        #if UNITY_EDITOR
        PfServerDebugger.Disconnect();
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
        
        wssClient.onConnect += () =>
        {
            Debug.Log("Connected to server.");
            counting = true;
            StartCoroutine(CountSeconds());
        };

        wssClient.onData += (data) =>
        {
            Debug.Log($"Server send: {data.WideString()}");
        };
        
        wssClient.onDisconnect += () =>
        {
            counting = false;
            Debug.Log("Disconnected from server.");
        };
    }

    public void SayHi()
    {
        endpontIp = endpontIp.Trim();
        wssClient.Connect(new Uri($"http://{endpontIp}:{endpontPort}"));
        wssClient.Send("Hi server!".ToBytes());
    }

    private void Update()
    {
        wssClient.ProcessMessageQueue(this);
    }

    private void OnDestroy()
    {
        #if UNITY_EDITOR
        PfServerDebugger.Disconnect();
        #endif
    }

    private bool counting;
    private IEnumerator CountSeconds()
    {
        int seconds = 0;
        while (counting)
        {
            Debug.Log(seconds++);
            yield return new WaitForSeconds(1);
        }
    }
}
