using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [SerializeField] Text score;
    [SerializeField] Text highScore;

    private void OnEnable()
    {
        int sc = ScoreCounter.score;

        if (sc > PlayerPrefs.GetInt("myScore"))
        {
            PlayerPrefs.SetInt("myScore", sc);
            highScore.text = sc.ToString();
        }
        else
        {
            highScore.text = PlayerPrefs.GetInt("myScore").ToString();
        }

        score.text = sc.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
}
