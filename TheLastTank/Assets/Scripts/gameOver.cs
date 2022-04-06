using UnityEngine;

public class gameOver : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 5f;
    [SerializeField]
    private float timeElapsed;              // 경과된 시간
    public GameObject reBtn;
    public GameObject exitBtn;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            reBtn.SetActive(true);
            exitBtn.SetActive(true);            
        }
    }

}
