using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float XBound = 20.0f;
    private float ZBound = 30.0f;
    private float startDalay = 2.0f;
    private float spawnIntervalx = 2.0f;
    private float spawnIntervaly = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal_X", startDalay, spawnIntervalx);
        InvokeRepeating("SpawnRandomAnimal_Y", startDalay, spawnIntervaly);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) {
            SpawnRandomAnimal_X();
            SpawnRandomAnimal_Y();
        }
    }

    void SpawnRandomAnimal_X()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
     //the position where will be spawn
        Vector3 spawnPos = new Vector3(Random.Range(-XBound, XBound), 0, ZBound);
     //spawn the object
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0));
    }
    void SpawnRandomAnimal_Y()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //the position where will be spawn
        Vector3 spawnPos = new Vector3(XBound, 0, Random.Range(-ZBound, ZBound));
        //spawn the object
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, -90, 0));

        animalIndex = Random.Range(0, animalPrefabs.Length);
        //the position where will be spawn
        spawnPos = new Vector3(-XBound, 0, Random.Range(-ZBound, ZBound));
        //spawn the object
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 90, 0));
        
    }
}
