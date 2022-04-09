using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField]
    public float delayBeforeLoading = 5f;
    [SerializeField]
    private float timeElapsed;              // 경과된 시간
    public GameObject nextBtn;
    public GameObject exitBtn;
    private GameObject[] enemy;             // 적 탱크
    private GameObject player;              // 플레이어 탱크
    public GameObject randomET;
    public GameObject randomTyphoon;

    private void Update()
    {
        RmCreate();
        RmEnemy();
        RmPlayer();
        VictoryBtn();            
    }

    private void VictoryBtn()
    {
        // Victory 문구와 함께 등장하는 버튼 활성화
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            nextBtn.SetActive(true);
            exitBtn.SetActive(true);            
        }
    }

    private void RmEnemy()
    {
        // 모든 적 탱크 및 적 비활성화
        enemy = GameObject.FindGameObjectsWithTag("Finish");

        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].SetActive(false);
        }

    }

    private void RmPlayer()
    {
        // 탱크 이동기능 비활성화
        player = GameObject.FindWithTag("Player");
        player.GetComponent<Tankmove>().enabled = false;
        player.GetComponent<CollideCH>().enabled = false;
    }

    private void RmCreate()
    {
        // 랜덤으로 생성하는 기능 비활성화
        randomET.GetComponent<TankEnemy>().enabled = false;
        randomTyphoon.GetComponent<RandomTyphoon>().enabled = false;
    }

}
