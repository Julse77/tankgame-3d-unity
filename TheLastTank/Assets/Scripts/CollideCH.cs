using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollideCH : MonoBehaviour
{
    
    public GameObject gameOvertext;
    public ParticleSystem Pinput;

        Text text;


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
            gameOvertext.SetActive(true);

            Instantiate(Pinput, transform.position, Quaternion.identity);

        }
    }     
}
