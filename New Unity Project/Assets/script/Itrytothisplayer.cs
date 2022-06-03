using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itrytothisplayer : MonoBehaviour
{
    public float speed = 12.5f;
    public float mousespeed = 100f;
    public CharacterController mycontroller;
    
    
    
   // public Quaternion cameraVerticalRotation;
  
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        playermovementkey();
        
       // playermovementmous();
       
        
    }
    

    void playermovementmous()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
        //camera up and down
        //mouseY = Input.GetAxis("Mouse Y");




        //float mouseY = Input.GetAxis("Mouse Y") * mousespeed * Time.deltaTime;
        //transform.Rotate(Vector3.down * mouseY);

        // cameraVerticalRotation -=mouseY;
        //myCamerahead.localPosition =  Quaternion.Euler(cameraVerticalRotation, 0f, 0f);

    }

    void playermovementkey()
    {
        {
            //you go to edit project settings and axis
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            Vector3 movement = x * transform.right + z * transform.forward;
            movement = movement * speed * Time.deltaTime;
            mycontroller.Move(movement);



        }   
    }
}
