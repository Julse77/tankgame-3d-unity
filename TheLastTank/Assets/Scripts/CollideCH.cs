using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollideCH : MonoBehaviour
{
    private Vector3 player;    
    public GameObject gameOvertext;             // 게임오버 텍스트
    public ParticleSystem Pinput;               // 파티클시스템

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
            gameOvertext.SetActive(true);       // 게임오버 텍스트 ON

            Instantiate(Pinput, transform.position, Quaternion.identity);
            // 파티클이 게임오브젝트 x y z 에 정확하게 드러나게 Quaternion.identity
        }
    }

    void falldown()
    {
        // 플레이어 탱크가 추락했을 경우
    }     
}
