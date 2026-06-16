using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] SoundManager sm;
    [SerializeField] Text scoreText;  
    public static int score;

    void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("counter"))  
        {
            sm.Point();
            score++;
            scoreText.text = score.ToString();
        }
    }
}
