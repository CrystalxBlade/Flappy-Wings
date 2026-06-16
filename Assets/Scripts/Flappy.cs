using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] bool isDead;
    [SerializeField] float speed;
    [SerializeField] GameObject gameOver;
    Animator anim;
    Rigidbody2D rb;
    private Collider2D coll;
    [SerializeField] SoundManager sm;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isDead == false)
        {
            sm.Flap();
            rb.linearVelocity = Vector2.up * speed;
        }

        if(Input.GetKey(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        sm.Hit();
        isDead = true;
        rb.linearVelocity = Vector2.up * speed;
        coll.enabled = false;
        anim.Play("Die");
        gameOver.SetActive(true);
    }

}
