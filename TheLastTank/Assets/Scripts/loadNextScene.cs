using UnityEngine;

public class LoadNextScene : MonoBehaviour{  

    public void GameStart()
    {
        loadingScene.LoadScene("Scene001");
    }

    public void GameExit()
    {
#if UNITY_EDITOR_WIN
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_EDITOR_OSX
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
                
    }
}