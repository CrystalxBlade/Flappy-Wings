using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Start() 
    {
        Destroy(gameObject, 4f);
    }
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; 
    }
}
