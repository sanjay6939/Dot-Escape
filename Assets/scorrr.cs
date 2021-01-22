using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorrr : MonoBehaviour {

    float score;
    float pointIncreasePerSecond;
    public Text scoreText;
    public Text highscore;

    void Start()
    {
        score = 0f;
        pointIncreasePerSecond = 1f;
        highscore.text= PlayerPrefs.GetFloat("Highscore",0).ToString("0");

    }

    void Update()
    {
        score += pointIncreasePerSecond * Time.deltaTime;
        scoreText.text = score.ToString("0");
        if (score > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", score);
            highscore.text = score.ToString("0");
        }
        
    }
}
