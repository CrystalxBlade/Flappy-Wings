using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float time;
    [SerializeField] float height;
    float timer;
    void Start()
    {
        timer = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= time)
        {
            timer = 0;
            Spawn();
        }
    }

    void Spawn()
    {
        Vector3 pos = transform.position + new Vector3(0, Random.Range(-height, height));
        Instantiate(pipe, pos, Quaternion.identity);
    }
}
