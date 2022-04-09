using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void ReStart()
    {
        SceneManager.LoadScene("Scene001");
    }

    public void NextStage()
    {
        SceneManager.LoadScene("Scene001");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Start");
    }

}
