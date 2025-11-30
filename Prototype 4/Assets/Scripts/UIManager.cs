using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    /*
    public Text waveCounterText;

    public void UpdateWaveText(int currentWave)
    {
        if (waveCounterText != null)
        {
            waveCounterText.text = "Wave: " + currentWave.ToString();
        }
    }
}*/


    public Text waveText;
    public int wave = 1;

    public PlayerController playerControllerScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (waveText == null)
        {
            waveText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        waveText.text = "Wave: 1";
    }

    // Update is called once per frame
    void Update()
    {
        //Display score until game is over
        if (!playerControllerScript.gameOver)
        {
            waveText.text = "Wave: " + wave;
        }

        //loss Condition: Hit the obstacle 
        if (playerControllerScript.gameOver && !won)
        {
            waveText.text = "You Lose!\nPress R to Try Again!";
        }

        //win Condition: 10 points
        if (wave >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;

            //Stop player running 

            waveText.text = "You Win!\nPress R to Try Again!";

        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
