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
    public GameObject reBtn;
    public GameObject exitBtn;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            reBtn.SetActive(true);
            exitBtn.SetActive(true);            
            //SceneManager.LoadScene("Scene001");
        }
    }

}
