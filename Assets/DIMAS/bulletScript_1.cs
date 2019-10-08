using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwShoots;

    public GameObject projectile;
    public Transform shotPoint;



    // Update is called once per frame
    void Update()
    {
        if (startTimeBtwShoots <= 0)
        {
            if (Input.GetButtonDown("fire1"))
            {
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShoots;
            }

        }
        else
        {
            timeBtwShots -= Time.deltaTime;
            Destroy(gameObject);
        }

    }


}
