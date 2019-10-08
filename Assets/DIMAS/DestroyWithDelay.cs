using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour
{
    public GameObject destroyEffect;
    public float delay;
    // Start is called before the first frame update
    void destroyAndEffect()
    {

        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
