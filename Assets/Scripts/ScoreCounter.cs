using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    void Start()
    {
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("counter"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
