using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hexagonPrefab;

    public float spawnRate = 1f;
    public float nextSpawnTime = 0.0f;
    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            Instantiate(hexagonPrefab, transform.position, Quaternion.identity);
            nextSpawnTime = Time.time + 1 / spawnRate;
        }
    }
}
