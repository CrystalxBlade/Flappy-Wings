using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 startPos;
    [SerializeField] float endPos;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < endPos)
        {
            transform.position = startPos;
        }
    }
}
