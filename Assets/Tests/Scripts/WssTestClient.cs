using System;
using System.Collections;
using CGT.Shared;
using UnityEngine;
using Mirror.SimpleWeb;
#if UNITY_EDITOR
using PlayFabServerTool;
#endif
using UnityEngine.UI;

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
    
    [SerializeField] private Text output;

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
            var message = "Connected to server.";
            Debug.Log(message);
            output.text = message;
            
            wssClient.Send("Hi server!".Bytes());
            
            counting = true;
            StartCoroutine(CountSeconds());
        };

        wssClient.onData += (data) =>
        {
            var message = data.WideString();
            Debug.Log($"Server send: {message}");
            output.text = message;
        };
        
        wssClient.onDisconnect += () =>
        {
            counting = false;
            
            var message = "Disconnected from server.";
            Debug.Log(message);
            output.text = message;
            
            StopAllCoroutines();
            SayHi();
        };
    }

    public void SayHi()
    {
        endpontIp = endpontIp.Trim();
        wssClient.Connect(new Uri($"ws://{endpontIp}:{endpontPort}"));
    }

    public void End()
    {
        wssClient.Disconnect();
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
