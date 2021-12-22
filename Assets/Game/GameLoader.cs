using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    using AWS.Auth;

    public class GameLoader : MonoBehaviour
    {
        public GameSessionMode mode;
        public int gameSceneIndex = 1;

        async void Start()
        {
            var gc = await LoadGC(mode);
            Debug.Log($"game controller created: {gc}");
            var sessionObj = new GameObject();
            DontDestroyOnLoad(sessionObj);
            var session = sessionObj.AddComponent<GameSession>();
            session.Init(gc);
            SceneManager.LoadScene(gameSceneIndex);
        }

        async Task<IGameControllerBase> LoadGC(GameSessionMode mode)
        {
            MetaNetworkLayer networkLayer;
            switch (mode)
            {
                case GameSessionMode.DevelopMode:
                    return new DevGameController();
                
                case GameSessionMode.DevelopCheckMode:
                    return new DevGameControllerWithChecks();
                
                case GameSessionMode.MergedServerMode:
                    networkLayer = await MergedClientMetaNetworkLayer.Create();
                    Debug.Log("Merged network layer created successfully");
                    return await ServerBasedGameController.Create((ClientMetaNetworkLayer) networkLayer);
                
                case GameSessionMode.RealServerMode:
                    throw new NotImplementedException();
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}