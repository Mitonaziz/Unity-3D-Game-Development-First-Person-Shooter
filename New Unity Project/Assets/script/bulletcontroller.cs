using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{
    public float speed ,bulletLife;

    public Rigidbody myRigidbody;
 
    void Start()
    {
        
    }

    
    void Update()
    {
        bulletfluy();
        bulletLife -= Time.deltaTime;
        if (bulletLife < 0)
        {
            Destroy(gameObject);
        }
    }

    private void bulletfluy()
    {
        myRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);//when bullet tuoch a body then destroy the bullet
        
    }
}
