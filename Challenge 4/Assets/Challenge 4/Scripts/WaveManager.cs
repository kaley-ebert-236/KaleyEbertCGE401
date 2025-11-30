using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveManager : MonoBehaviour
{
    public Text waveCounterText;
    private int currentWave;

    public void StartNewWave()
    {
        currentWave++;
        UpdateWaveDisplay();
        Debug.Log("Starting Wave: " + currentWave); 
        
    }

    private void UpdateWaveDisplay()
    {
        if (waveCounterText != null)
        {
            waveCounterText.text = "Wave: " + currentWave.ToString();
        }
        else
        {
            Debug.LogError("Wave Counter Text is not assigned in the Inspector!");
        }
    }

    void Start()
    {
        StartNewWave();
    }
}
