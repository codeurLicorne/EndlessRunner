using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweeenSpawns;
    private float spawnTime;

    public float spawnAmount;
    public float spawnIncrease;

    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweeenSpawns;
        }

        if(spawnAmount == 10)
        {
            timeBetweeenSpawns -= spawnIncrease;
            spawnAmount = 0;
        }

    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        spawnAmount++;
    }
}
