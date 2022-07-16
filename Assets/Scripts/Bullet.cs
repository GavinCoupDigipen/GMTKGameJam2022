//------------------------------------------------------------------------------
//
// File Name:	Bullet.cs
// Author(s):	Gavin Cooper (gavin.cooper)
// Project:	    GMTK GameJam 2022
//
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Tooltip("The base damage from the gun")]
    public int baseDamage = -1;
    [Tooltip("The damage value rolled")]
    public int rolledValue = -1;
    [Tooltip("The number of sides the dice has")]
    public int numSides = 6;
    [Tooltip("The sprites for dice")]
    public Sprite[] sprites;
    [Tooltip("The velocity of the bullet")] [SerializeField]
    private float velocity = 15;

    // Shoot the bullet
    public void Shoot()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.currentHealth -= (rolledValue + baseDamage);
            Destroy(gameObject, 0.1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.currentHealth -= (rolledValue + baseDamage);
            Destroy(gameObject);
        }
    }
}
