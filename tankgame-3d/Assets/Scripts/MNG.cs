using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MNG : MonoBehaviour
{
    public Transform target2;
    Ray ray;
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        // 마우스 클릭 된 위치에 ray 만들기
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // 만들어진 Ray로 hit 된 곳이 있는지 확인하기
        if (Physics.Raycast(ray, out hit))
        {
            target2.transform.position = new Vector3(hit.point.x, 0, hit.point.z);            
        }    

        // 마우스 왼쪽 버튼 클릭할 때
        if(Input.GetMouseButtonDown(0))
        {            
            // 만들어진 Ray로 hit 된 곳이 있는지 확인하기
            Debug.Log("Hit x =" + hit.point.x + "z= " + hit.point.z);
        }
        
    }
}
