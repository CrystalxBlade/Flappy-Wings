using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float SpawnTime, height;
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
        Instantiate(pipe, transform.position + new Vector3(0,Random.Range(-height, height)), Quaternion.identity);
    }
}
