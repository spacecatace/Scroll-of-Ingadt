using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    // This is the target that the AI will chase
    public GameObject target;
    // This is the distance how close the enemy will get to the target
    public float minDistanceBetween;
    // This is the distance how far the enemy will start following target
    public float maxDistanceBetween;

    // Walking speed of the AI
    private float speed;
    // Distance between the AI and the target
    private float distance;
    // Reference to the Rigidbody2D component, movement is physics-based
    private Rigidbody2D rb = null;
    // This is the vector that will be used to move the AI
    private Vector2 moveVector = Vector2.zero;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        // Unity is able to find the EnemyStats component due to inheritance
        speed = GetComponent<Stats>().moveSpeed;
    }

    // Use FixedUpdate to avoid spamming Time.deltaTime
    void FixedUpdate() {
        // Reset the moveVector
        moveVector = Vector2.zero;
        // Only move is target is not null
        if (target != null)
        {
            distance = Vector2.Distance(transform.position, target.transform.position);
            // If distance is between minDistanceBetween and maxDistanceBetween, then move towards target
            if(distance > minDistanceBetween && distance < maxDistanceBetween)
            {
                moveVector = (target.transform.position - transform.position).normalized;
            }
        }
        // Use the moveVector to move the AI, no movement if moveVector is zero
        rb.velocity = moveVector * speed;
    }
}
