/*
Kaley Ebert
Assignment 3
Destroys the pizza and the animal prefabs once they are out of bounds 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        //if food is out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //if animal goes out of bounds
        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");

            //grab the HealthSystem script and call the TakeDamage()
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }
    }
}
