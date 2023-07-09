using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class Car : Vehicle
{
    void Start() {
        playerRb = gameObject.GetComponent<Rigidbody>();
        playerRb.centerOfMass = transform.Find("COM").localPosition;
        speed = 8000.0f;
        rotateSpeed = 2.0f;
        vehicleName = "Car";
    }
    void FixedUpdate()
    {
        if (isGrounded)
        {
            move();
        }
    }
}
