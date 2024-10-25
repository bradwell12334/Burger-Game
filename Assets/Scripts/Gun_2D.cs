using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_2D : MonoBehaviour
{
    public Transform bulletSpawnPoint; // Assign this in the Inspector
    public GameObject bulletPrefab; // Assign your bullet prefab here
    public float bulletSpeed = 10; // Speed of the bullet
    public float fireRate = 0.5f; // Time between shots
    private float nextFireTime = 0f; // Track the next time the gun can fire

    void Update()
    {
        // Check if the fire key (F) is pressed and if enough time has passed since the last shot
        if (Input.GetKeyDown(KeyCode.F) && Time.time >= nextFireTime)
        {
            FireBullet();
            nextFireTime = Time.time + fireRate; // Update the next fire time
        }
    }

    void FireBullet()
    {
        Debug.Log("Firing Bullet"); // Debug log to check if firing
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Set bullet direction based on the gun's rotation
        rb.velocity = bulletSpawnPoint.up * bulletSpeed;

        // Optional: Add some effects, like sound or visual effects here
        // AudioSource.PlayClipAtPoint(shootSound, transform.position);
        // Instantiate(muzzleFlashPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}
