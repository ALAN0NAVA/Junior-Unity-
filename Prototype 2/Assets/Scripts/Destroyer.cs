using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float bound = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > bound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -bound)
        {
            Destroy(gameObject);
        }
    }
}
