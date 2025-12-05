using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0f;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
            Destroy(gameObject);
        }
    }
}
