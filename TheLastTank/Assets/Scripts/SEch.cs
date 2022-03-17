using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SEch : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 5f;
    [SerializeField]
    private string Scene001;
    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("Scene001");
        }
    }

}
