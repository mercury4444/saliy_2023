using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSapsan : MonoBehaviour
{
    public GameObject sapsan;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn = 6f;

    public float startPosition = -5f;
    public float endPosition = 5f;
    
    void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn; 
    }

    // Update is called once per frame
    void Update()
    {
        timeBtwSpawn -= Time.deltaTime;
        if (timeBtwSpawn <= 0)
        {
            Vector2 spawnPos = new Vector2(transform.position.x, Random.Range(startPosition, endPosition));
            Instantiate(sapsan, spawnPos, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
    }
}
