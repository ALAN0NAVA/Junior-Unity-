using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class collectible : MonoBehaviour
{
    public GameObject onCollectorEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //para que solo haga efefcto con el jugador
        {
            //destroy the collectible
            Destroy(gameObject);//
                                //instanciar el efecto
            Instantiate(onCollectorEffect, transform.position, transform.rotation);
        }

    }
}
