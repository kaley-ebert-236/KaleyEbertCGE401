using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveDisplay : MonoBehaviour
{
    public Text waveText;
    public int currentWave = 1;

    void Awake()
    {
        if (waveText == null)
            waveText = GameObject.Find("WaveText").GetComponent<Text>();

        if (waveText == null)
            Debug.LogError("waveText is null!");
        UpdateWaveUI();
    }

    void Start()
    {
        UpdateWaveUI();
    }

    public void SetWave(int wave)
    {
        currentWave = wave;
        UpdateWaveUI();
    }

    void UpdateWaveUI()
    {
        if (waveText != null)
            waveText.text = "Wave: " + currentWave;
        else
            Debug.LogWarning("Wave Text is null!");
    }
}
