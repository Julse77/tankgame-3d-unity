using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eattack : MonoBehaviour
{
    public ParticleSystem explosion;        // 파티클
    public int scoreValue = 10;             // 점수
    bool isDead;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {
            ScoreManager.score += scoreValue;
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);

        }
    }


}
