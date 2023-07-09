using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    void Start() {
        playerRb = gameObject.GetComponent<Rigidbody>();
        playerRb.centerOfMass = COM.localPosition;
        speed = 12000.0f;
        rotateSpeed = 3.0f;
        vehicleName = "Plane";
    }
    void FixedUpdate()
    {
        move();
    }
    public override void move(){
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        if (verticalInput>0)
        {
            playerRb.AddForce(transform.forward * verticalInput * speed);
        }
        if(Input.GetKey(KeyCode.Z)){
            transform.Rotate(Vector3.right * rotateSpeed);
        }
        if(Input.GetKey(KeyCode.X)){
            transform.Rotate(-Vector3.right * rotateSpeed);
        }
        transform.Rotate(-Vector3.forward * horizontalInput*rotateSpeed);
    }

}
