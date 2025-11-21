using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    //public Text textbox;
    public GameObject youWinPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) // Ensure your player GameObject has the "Player" tag
        {
            if (youWinPanel != null)
            {
                youWinPanel.SetActive(true); // Activate the "You Win" UI element
            }
        }

        /*
        if (other.CompareTag("TriggerZone"))
        {
            //textbox.text = "You Win!";
            ScoreManager.score++;
        }
        */
    }
}
