using UnityEngine;

public class LoadNextScene : MonoBehaviour{  

    public void GameStart()
    {
        loadingScene.LoadScene("Scene001");        
    }

    public void GameExit()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        
        else if (Application.platform == RuntimePlatform.OSXEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }

        else
        {
            Application.Quit();
        }
                
    }
}
