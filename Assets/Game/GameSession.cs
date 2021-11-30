using System;
using System.Threading.Tasks;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public static GameSession instance;
    public static GameModel game => instance.gameController.game;
    public static bool active => instance.gameController != null;
    
    public IGameControllerBase gameController;

    public void Init(IGameControllerBase gc)
    {
        gameController = gc;
        instance = this;
        gameController.RestartNeeded().Subscribe(async message =>
        {
            // TODO show popup and restart
            Debug.LogError($"Game controller require restart with message:{message}");
            await Finish();
        });
    }

    public async Task Finish()
    {
        instance = null;
        await gameController.Exit();
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }

    void OnApplicationQuit()
    {
        gameController.OnApplicationPause();
    }
    
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus) gameController.OnApplicationPause();
    }
    
    void Update()
    {
        gameController.OnUnityUpdate();
    }
}