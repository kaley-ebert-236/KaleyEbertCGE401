using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody enemyRB;
    public GameObject player;
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //Add force toward the direction from the player to the enemy 

        //vector for direction from enemy to palyer
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        //add force towards player
        enemyRB.AddForce(lookDirection * speed);
    }
}
