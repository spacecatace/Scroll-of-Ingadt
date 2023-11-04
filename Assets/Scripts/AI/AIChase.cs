using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    public  GameObject target;
    // Walking speed of the AI
    public float speed = 5f;
    // This is the distance how close the enemy will get to the target
    public float minDistanceBetween;
    // This is the distance how far the enemy will start following target
    public float maxDistanceBetween;

    private float distance;
    private Rigidbody2D rb = null;
    private Vector2 moveVector = Vector2.zero;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        distance = Vector2.Distance(transform.position, target.transform.position);
        if(distance > minDistanceBetween && distance < maxDistanceBetween)
        {
            moveVector = (target.transform.position - transform.position).normalized;
        }
        else
        {
            moveVector = Vector2.zero;
        }
        rb.velocity = moveVector * speed;
    }
}
