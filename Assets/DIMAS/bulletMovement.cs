using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    GameObject destroyEffect;
    public int damage = -10;


    // adds spped the the bullets movements
    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    //detects collision and applies damage to the enemy it also creates
    //an effect when enemy is destroyed
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);

        enemyLife enemy = hitInfo.GetComponent<enemyLife>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(destroyEffect, transform.position, transform.rotation);
        Destroy(gameObject);

        
    }
}
