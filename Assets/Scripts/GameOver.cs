using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private void OnEnable()
    {
        int score = ScoreCounter.score;

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
        else
        {
            scoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }

        scoreText.text = score.ToString();
    }
}
