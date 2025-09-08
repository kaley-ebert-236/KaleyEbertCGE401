/*
* (Kaley Ebert)
* (Assignment 2 (Prototype 1 & Challenge 1)
* (Score goes up entering trigger zone)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to the player
public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }


}
