using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable
{
    protected float speed;
    protected int health;

    [Serializedfield] protected Weapon weapon;

    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<weapon>();

        speed = 5f; 
        health = 100;
    }

    protected abstract void Attack(int amount);

    /*
    {
        Debug.Log("Enemy attacks!");
    }
    */

    public abstract TakeDamage(int amount);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
