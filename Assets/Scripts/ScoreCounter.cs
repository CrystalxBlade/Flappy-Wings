using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] Text scoreText;  
    int score;

    void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("counter"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
