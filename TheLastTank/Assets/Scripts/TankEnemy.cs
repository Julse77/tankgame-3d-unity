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

    // Start is called before the first frame update
    void Start()
    {
        EcurrentTime = 0;
        ERdtime = 7f;        
    }

    // Update is called once per frame
    void Update()
    {
        EcurrentTime += Time.deltaTime;

        if (EcurrentTime > ERdtime)
        {
            Emovex = Random.Range(10f, 190f);
            Emovey = 10f;
            Emovez = Random.Range(10f, 190f);

            Vector3 Epos = new Vector3(Emovex, Emovey, Emovez);
            Instantiate(Eprefab, Epos, Eprefab.transform.rotation);      // 없는 것을 새롭게 만드는 것

            ERdtime = Random.Range(4f, 7f);
            EcurrentTime = 0;
        }
    }  

}
