using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonEvent : MonoBehaviour
{
    public void reStart()
    {
        SceneManager.LoadScene("Scene001");
    }

    public void nextStage()
    {
        SceneManager.LoadScene("Scene001");
    }

    public void exit()
    {
        SceneManager.LoadScene("start");
    }

}
