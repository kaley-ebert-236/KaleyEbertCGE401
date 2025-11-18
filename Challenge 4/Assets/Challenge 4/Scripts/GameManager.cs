using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public WaveDisplay waveDisplay;

    public Text messageText;
    public Text startText;

    public bool gameStarted = false;
    public bool gameOver = false;

    private int loseCount = 0;
    public int maxEscapedEnemies = 1;
    public int maxWave = 10;

    void Start()
    {
        // Game begins paused
        Time.timeScale = 1;
        messageText.gameObject.SetActive(false);
    }

    void StartGame()
    {
        startText.gameObject.SetActive(false);
        gameStarted = true;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }

            if (gameOver)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
        }

        void StartGame()
        {
            startText.gameObject.SetActive(false);
            gameStarted = true;
            Time.timeScale = 1; // Resume game
            escapedEnemies = 0;
            waveDisplay.SetWave(1);
        }

        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    // Called when enemy reaches goal
    public void EnemyEscaped()
    {
        if (gameOver) return;

        loseCount++;
        if (loseCount >= maxEscapedEnemies)
        {
            LoseGame();
        }
    }

    public void NextWave()
    {
        if (gameOver) return;

        int next = waveDisplay.currentWave + 1;

        if (next > maxWave)
        {
            WinGame();
            return;
        }

        waveDisplay.SetWave(next);
    }

    void WinGame()
    {
        gameOver = true;
        Time.timeScale = 0;
        messageText.text = "You Win! Press R to Restart!";
        messageText.gameObject.SetActive(true);
    }

    void LoseGame()
    {
        gameOver = true;
        Time.timeScale = 0;
        messageText.text = "You Lose! Press R to Restart!";
        messageText.gameObject.SetActive(true);
    }
}
