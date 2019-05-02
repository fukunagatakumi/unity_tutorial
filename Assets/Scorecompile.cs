using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecompile : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;

    public int score = 0;
    public int highscore = 0;
    public string highscorekey = "highscore";

    private void gameInitialized()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt(highscorekey, 0);
    }

    public void Addpoint(int point)
    {
        score += point;
    }

    public void gamesaved()
    {
        PlayerPrefs.SetInt(highscorekey, highscore);
        PlayerPrefs.Save();
        gameInitialized();
    }

    // Start is called before the first frame update
    void Start()
    {
        gameInitialized();
    }

    // Update is called once per frame
    void Update()
    {
        if (highscore < score) highscore = score;
        ScoreText.text = score.ToString();
        HighScoreText.text = highscore.ToString();
    }
}
