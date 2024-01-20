using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapShooter : MonoBehaviour
{
    public GameObject projectilePrefab; // prefab for the projectile
    public float shootingInterval = 2.0f; // time between shots
    public float shootingSpeed = 10.0f; // speed of the projectile
    public float projectileLifetime = 1.0f; // how long the projectile lasts
    public Vector2 shootingDirection = Vector2.down; // default shooting direction

    private float shootingTimer;

    void Start()
    {
        shootingTimer = shootingInterval;
    }

    void Update()
    {
        shootingTimer -= Time.deltaTime;
        if (shootingTimer <= 0)
        {
            ShootProjectile();
            shootingTimer = shootingInterval;
        }
    }

    void ShootProjectile()
    {
        
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = shootingDirection.normalized * shootingSpeed;
        
        Destroy(projectile, projectileLifetime);
        
    }
}