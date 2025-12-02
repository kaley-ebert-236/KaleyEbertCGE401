using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            //wait 1 second
            yield return new WaitForSeconds(spawnRate);

            //pick a random index between 0 and the number of prefabs
            int index = Random.Range(0, targets.Count);

            //spawn the prefab at the randomly selected inex
            Instantiate(targets[index]);

            //testing UpdateScore by adding every time a new target spawns
            //UpdateScore(5);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
