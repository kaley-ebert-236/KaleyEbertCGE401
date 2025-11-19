using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    //public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            ScoreManager.score++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
