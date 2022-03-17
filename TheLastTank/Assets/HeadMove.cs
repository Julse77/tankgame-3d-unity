using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        gameObject.transform.LookAt(target);
    }
}
