﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
        }
    }
}
