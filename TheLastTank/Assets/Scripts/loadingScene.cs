using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingScene : MonoBehaviour
{
    static string playScene;

    [SerializeField]
    Image Loadingbar;

    public static void LoadScene(string sceneName)
    {
        playScene = sceneName;
        SceneManager.LoadScene("loading");    
    }

    
    void Start()
    {
        StartCoroutine(LoadSceneProcess());
    }

    IEnumerator LoadSceneProcess()
    {
        AsyncOperation opp = SceneManager.LoadSceneAsync(playScene);
        opp.allowSceneActivation = false;

        float timer = 0f;

        while (!opp.isDone)
        {
            yield return null;
            if (opp.progress < 0.9f)
            {
                Loadingbar.fillAmount = opp.progress;
            }
            else {

                timer += Time.unscaledDeltaTime;
                Loadingbar.fillAmount = Mathf.Lerp(0.9f, 1f, timer);
                if (Loadingbar.fillAmount >= 1f)
                {
                    opp.allowSceneActivation = true;
                    yield break;
                
                
                }
            
            }
        
        }
    
    }

}
