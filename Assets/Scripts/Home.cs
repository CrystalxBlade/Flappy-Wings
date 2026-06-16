using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Home : MonoBehaviour
{
    [SerializeField] Text highScore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

