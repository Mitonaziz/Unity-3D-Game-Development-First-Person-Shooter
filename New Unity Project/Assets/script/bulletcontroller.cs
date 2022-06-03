using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{
    public float speed;

    public Rigidbody myRigidbody;
 
    void Start()
    {
        
    }

    
    void Update()
    {
        bulletfluy();
    }

    private void bulletfluy()
    {
        myRigidbody.velocity = transform.forward * speed;
    }
}
