using UnityEngine;

public class Parallex : MonoBehaviour
{
    [SerializeField] float parallexSpeed;
    Vector3 startPos;
    [SerializeField] float endPoint;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if(transform.position.x <= endPoint)
        {
            transform.position = startPos;
        }
        transform.position += Vector3.left * parallexSpeed * Time.deltaTime;
    }
}
