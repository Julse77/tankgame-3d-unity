using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeadMove : MonoBehaviour
{
    public Transform target;

    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(target);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
     
}
