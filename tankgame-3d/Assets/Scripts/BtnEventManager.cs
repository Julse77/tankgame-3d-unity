using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnEventManager : MonoBehaviour{  

    public void StartGame()
    {
        LoadingScene.LoadScene("Scene_Stage_01");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR_OSX
        EditorApplication.isPlaying = false;
#elif UNITY_EDITOR_WIN
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }

    public void ReStart()
    {
        SceneManager.LoadScene("Scene_Stage_01");
    }

    public void NextStage()
    {
        SceneManager.LoadScene("Scene_Stage_01");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Scene_Start");
    }
}