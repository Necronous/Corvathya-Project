using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInitializer : MonoBehaviour
{
    public static GameInitializer Instance { get; private set; }

    private void OnEnable()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);

        Application.targetFrameRate = 60;

        SaveManager.Create();
        WorldVariables.Reset();
        MapManager.Create();
    }


    private void Update()
    {
        MapManager.Instance.Update();
    }

    public void CreateGame()
    {
        MapManager.Instance.LoadMap(WorldVariables.Get<int>(WorldVariables.CURRENT_MAP_INDEX));
        PlayerController.Instance.Load();
        CameraController.Instance.SetStaticCamera();
        CameraController.Instance.SetPosition(PlayerController.Instance.transform.position);
        CameraController.Instance.StartFade(Color.black, .5f, CameraController.Instance.SetPlayerFollowCamera, true);
        //Player.PauseInput = false;
    }

    public void QuitToMainMenu()
    {
        //Assume saving has been done.
        PlayerController.Instance.PauseInput = true;
        MapManager.Instance.LoadMap("MainMenu");
        WorldVariables.Reset();
    }
}
