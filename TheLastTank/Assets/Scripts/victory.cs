using UnityEngine;

public class victory : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 5f;
    [SerializeField]
    private float timeElapsed;              // 경과된 시간
    public GameObject NextBtn;
    public GameObject exitBtn;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            NextBtn.SetActive(true);
            exitBtn.SetActive(true);            
        }
    }
}
