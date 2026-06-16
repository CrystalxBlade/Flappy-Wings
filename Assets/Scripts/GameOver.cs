using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject pauseButton;
    void Update()
    {
        pauseButton.SetActive(false);
    }
}
