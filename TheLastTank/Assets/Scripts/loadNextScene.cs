using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNextScene : MonoBehaviour
{    
    void Update()
    {
        // Space 바를 누르면 다음 씬이 나오도록
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadingScene.LoadScene("Scene001");
        }
    }
}
