using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    int spawnInterval = 3;
    private float delayBeforeSpawn = 3f;

    // Start is called before the first frame update
    void Update()
    {
        if (delayBeforeSpawn <= 0)
        {
            //If true spawn a ball and generate a random time
            SpawnRandomBall();
            delayBeforeSpawn = Random.Range(3, 5);
        }
        else
        {
            //If false reducing the time before spawn. Using Time.deltaTime because it can simulate a real countdown.
            delayBeforeSpawn -= Time.deltaTime;
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0,ballPrefabs.Length)], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
