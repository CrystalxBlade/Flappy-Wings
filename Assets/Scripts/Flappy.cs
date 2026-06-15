using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            rb.linearVelocity = Vector2.up * speed;
        }
    }

}
