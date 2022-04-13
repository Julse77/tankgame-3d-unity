using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public static int score;
    public GameObject Victorytext;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score;

        if(score > 30)
        {
            Victorytext.SetActive(true);
        }

    }
}
