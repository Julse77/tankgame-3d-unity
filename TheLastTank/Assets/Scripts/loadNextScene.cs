using UnityEngine;

public class loadNextScene : MonoBehaviour{  

    public void gameStart()
    {
        loadingScene.LoadScene("Scene001");        
    }

    public void gameExit()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        
        else
        {
            Application.Quit();
        }
                
    }
}
