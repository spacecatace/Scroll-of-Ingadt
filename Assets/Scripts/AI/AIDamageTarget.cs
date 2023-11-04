using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDamageTarget : MonoBehaviour
{
    public PlayerHealth playerHealth;
    // How often can attack
    public float attackInterval = 1;
    // Damage amount
    public int damageAmount;

    private float lastAttackTime;

    private void OnCollisionStay2D(Collision2D collision)
    {
        // If time since last attack < attackSpeed, then don't attack
        if(Time.time - lastAttackTime < attackInterval) return;

        if(collision.gameObject.CompareTag("Player"))
        {
            // Damage player
            playerHealth.TakeDamage(damageAmount);

            // Mark this point as last time attacked
            lastAttackTime = Time.time;
        }
    }
}
