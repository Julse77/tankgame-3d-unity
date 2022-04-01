using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankMove : MonoBehaviour
{
    public Transform target;        // 플레이어 탱크 위치

    public float speed = 3f;        // 적 탱크 이동속도

    void Update()
    {
        gameObject.transform.LookAt(target);                    // 플레이어 탱크 바라보게
        transform.Translate(0, 0, speed * Time.deltaTime);      // 적 탱크 플레이어 탱크 방향으로 이동
    }
     
}
