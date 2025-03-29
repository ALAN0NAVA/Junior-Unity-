using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float XBound = 20.0f;
    private float ZBound = 20.0f;
    private float startDalay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDalay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        //Random number for the displacement in X
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //the position where will be spawn
        Vector3 spawnPos = new Vector3(Random.Range(-XBound, XBound), 0, ZBound);
        //spawn the object
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
