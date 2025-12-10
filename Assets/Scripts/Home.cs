using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Home : MonoBehaviour
{
    public Text highScore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
