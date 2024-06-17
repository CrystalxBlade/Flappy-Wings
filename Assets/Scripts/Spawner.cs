using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float spawnTime;
    [SerializeField] float height;
    float timer;
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            timer = 0;
            Spawn();
        }
    }
    void Spawn()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-height, height));
        Instantiate(pipe, spawnPos, Quaternion.identity);
    }
}
