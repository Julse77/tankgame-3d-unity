using System.Collections;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;
    Vector3 offset;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
        offset = player.transform.position - transform.position;
    }


    void LateUpdate()
    {
        transform.position = player.transform.position - offset; 
    }
}
