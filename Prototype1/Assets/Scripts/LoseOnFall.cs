/*
* (Kaley Ebert)
* (Assignment 2 (Prototype 1 & Challenge 1)
* (Puts up Game Over when falling off side)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this script to the player
public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }

    }
}
