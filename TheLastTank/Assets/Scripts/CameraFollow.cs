using System.Collections;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;          // 플레이어
    Vector3 offset;             // 플레이어 위치 - 카메라 위치


    void Start()
    {
        player = GameObject.FindWithTag("Player");
        offset = player.transform.position - transform.position;
    }


    void LateUpdate()
    {
        transform.position = player.transform.position - offset;        // 플레이어 위치 - 카메라 위치 만큼 이동하도록 
    }
}
