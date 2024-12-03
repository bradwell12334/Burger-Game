using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    // Detect collision with objects that have a collider marked as a trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object hit has the "Enemy" tag
        if (other.CompareTag("Enemy"))
        {
            // Destroy both the bullet and the enemy
            Destroy(gameObject);  // Destroy the bullet
            Destroy(other.gameObject);  // Destroy the enemy
            // 
        }
    }
}
