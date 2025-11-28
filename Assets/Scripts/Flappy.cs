using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] bool isDead = false;
    Animator anim;
    Collider2D coll;
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isDead == false)
        {
            rb.linearVelocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        anim.Play("die");
        coll.enabled = false;
        rb.linearVelocity = Vector2.up * speed;
    }
}
