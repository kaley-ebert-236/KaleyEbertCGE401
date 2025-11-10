/*
Kaley Ebert
Challenge 2
Controls to use to move the player  
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireDelay = 60f;

    // Update is called once per frame
    void Update()
    {
        fireDelay -= 0.1f;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && fireDelay <= 0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireDelay = 40f;
        }
    }
}
