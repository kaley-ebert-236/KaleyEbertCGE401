using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{
    //public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //gameManager.AddScore(1);
            Debug.Log("Object fell! Score increased");
            
            Destroy(other.gameObject);
        }

        /*
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player fell off the world! Game over.");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
