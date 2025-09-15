using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnTime;
    [SerializeField] private float timeBetweenSpawns;


    void Update()
    {
        if (Time.time >= spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawns;
        }
    }

    void Spawn()
    {
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }   

}
