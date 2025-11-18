using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text scoreText;
    private int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
