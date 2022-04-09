using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    public float delayBeforeLoading = 5f;
    [SerializeField]
    private float timeElapsed;              // 경과된 시간
    public GameObject reBtn;
    public GameObject exitBtn;
    public GameObject mainCamera;

    private void Update()
    {
        CameraOff();
        GameOverBtn();        
    }

    private void GameOverBtn()
    {
        // 게임 오버 시 등장하는 버튼 활성화
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            reBtn.SetActive(true);
            exitBtn.SetActive(true);            
        }
    }

    private void CameraOff()
    {
        // 메인 카메라 플레이어 탱크 따라가는 기능 비활성화
        mainCamera.GetComponent<CameraFollow>().enabled = false;
    }

}
