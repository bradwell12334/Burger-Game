using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Duration (in seconds) before the bullet is automatically destroyed
    public float life = 3;

    void Awake()
    {
        // Schedule the bullet to be destroyed after its life duration
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is tagged as "Enemy"
        // or if it has the name "Obsticle"
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.name == "Obsticle")
        {
            // Destroy the enemy or obstacle upon collision
            Destroy(collision.gameObject);
        }

        // Destroy the bullet regardless of what it collides with
        Destroy(gameObject);
    }
}
