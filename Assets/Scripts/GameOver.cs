using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [SerializeField] Text currentScore;
    [SerializeField] Text highScore;
    [SerializeField] GameObject pauseButton;
    void Update()
    {
        pauseButton.SetActive(false);
    }
    private void OnEnable()
    {
        int score = ScoreCounter.score;
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }
        else
        {
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        currentScore.text = score.ToString();
    }

    public void Retry()
    {
        Pause.Retry();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Home");
    }
}
