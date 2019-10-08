using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLife : MonoBehaviour
{

    public int health = 100;
    public GameObject deathEffect;


    //takes off damage value to the health of the enemy
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0 )
        {
            Die();
        }

    }

    //death affect and destpry enemy object
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
