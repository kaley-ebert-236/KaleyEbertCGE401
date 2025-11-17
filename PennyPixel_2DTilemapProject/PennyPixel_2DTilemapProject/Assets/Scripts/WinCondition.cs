using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public GameObject winTextGameObject;

    void Start()
    {
        if (winTextGameObject != null)
        {
            winTextGameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (winTextGameObject != null)
            {
                winTextGameObject.SetActive(true);
            }
            Debug.Log("Player entered the win zone!");
        }
    }
}
