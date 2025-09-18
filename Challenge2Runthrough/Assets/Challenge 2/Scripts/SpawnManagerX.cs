/*
* Arnoldo "Arnie" Quinones
* Challenge 2
* Code Description: Random Generation for Balls
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    
    public HealthSystemX healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystemX>();
        
        StartCoroutine(SpawnRandomBallCoroutine());
    }

    IEnumerator SpawnRandomBallCoroutine()
    {
        yield return new WaitForSeconds(startDelay);

        while (!healthSystem.gameOver)
        {
            SpawnRandomBall();

            float spawnInterval = Random.Range(3f, 5f);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int index = Random.Range(0, ballPrefabs.Length);
        
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }

}
