using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text waveCounterText;

    void Start()
    {
        
    }

    public void UpdateWaveText(int waveNumber)
    {
        if (waveCounterText != null)
        {
            waveCounterText.text = "Wave: " + waveNumber.ToString();
        }
    }
}
