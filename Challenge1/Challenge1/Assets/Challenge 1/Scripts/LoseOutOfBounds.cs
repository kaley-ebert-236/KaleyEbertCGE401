/*
* (Kaley Ebert)
* (Assignment 2 - Challenge 1)
* (Lose Condition - Out of Bounds)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOutOfBounds : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
        if (transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }

    }
}
