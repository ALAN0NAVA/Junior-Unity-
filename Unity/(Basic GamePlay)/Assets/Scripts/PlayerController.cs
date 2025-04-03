using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    private float speed = 15.0f;
    private float xRange = 17.0f;
    private float zRange = 22.0f;
    private float shootDelay = 0.2f;

    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        // Limitar al jugador que no sobrepase las cordenadas en el eje x y z
        if (transform.position.x <= -xRange){
            /*detener*/transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);}
          else if (transform.position.x >= xRange){
            /*detener*/transform.position = new Vector3(xRange, transform.position.y, transform.position.z);}

        if (transform.position.z <= -zRange){
            /*detener*/transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);}
          else if (transform.position.z >= zRange){
            /*detener*/transform.position = new Vector3(transform.position.x, transform.position.y, zRange);}


        // Mover el jugador 
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
        HorizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * HorizontalInput * Time.deltaTime * speed);

        // detectar la tecla espacio
        if(shootDelay <= 0) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Lanza el proyectil
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                shootDelay = 0.2f;
            }
        }
        else shootDelay -= Time.deltaTime; 
        

    }
}
