using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : MonoBehaviour
{
    private float Emovex;
    private float Emovey;
    private float Emovez;

    private float EcurrentTime;

    private float ERdtime;

    public GameObject Eprefab;

    void Start()
    {
        EcurrentTime = 0;
        ERdtime = 7f;        
    }

    void Update()
    {
        EcurrentTime += Time.deltaTime;

        if (EcurrentTime > ERdtime)
        {
            Emovex = Random.Range(10f, 190f);
            Emovey = 10f;
            Emovez = Random.Range(10f, 190f);

            Vector3 Epos = new Vector3(Emovex, Emovey, Emovez);
            Instantiate(Eprefab, Epos, Eprefab.transform.rotation);      // 적 탱크 랜덤위치 생성

            ERdtime = Random.Range(4f, 7f);
            EcurrentTime = 0;
        }
    }  

}
