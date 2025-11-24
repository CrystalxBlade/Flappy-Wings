using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float SpawnTime;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > SpawnTime)
        {
            Spawn();
            timer = 0;
        }
    }

    private void Spawn()
    {
        Instantiate(pipe, transform.position, Quaternion.identity);
    }
}
