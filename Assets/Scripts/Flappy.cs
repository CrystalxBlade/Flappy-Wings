using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public SoundManager SM;
    [SerializeField] float speed;
    [SerializeField] GameObject gameOver;
    bool isDead = false;
    Rigidbody2D rb;
    Animator anim;
    Collider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            rb.velocity = Vector2.up * speed;
            SM.Play_Flap();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
        anim.Play("Die");
        coll.enabled = false;
        gameOver.SetActive(true);
        SM.Play_Hit();
    }

}
