using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // When an object enters the collision zone of the enemy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object colliding is the bullet of the enemy
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Destroy the bullet of enemy
            Destroy(collision.gameObject);
            {
                // Destroy the enemy from this object
                Destroy(gameObject);
            }


        }
    }
}