using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnDelay = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (spawnDelay <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnDelay = 2;
            }
        }
        else { spawnDelay -= Time.deltaTime; }
    }
}
