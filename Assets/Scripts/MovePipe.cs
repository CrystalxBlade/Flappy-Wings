using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; 
    }
}
