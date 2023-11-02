using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health;
    // Max health of the target
    public int maxHealth = 10;

    void Start()
    {
        Health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log("Player took " + damage + " damage. Health is now " + Health);
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
