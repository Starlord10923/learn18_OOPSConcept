using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public Rigidbody playerRb;
    public float speed;
    public float rotateSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float velocity;
    public bool status = false;
    public bool isGrounded = true;
    public string vehicleName;
    public Transform COM;
    public virtual void move(){
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        velocity = playerRb.velocity.magnitude;
        if (playerRb.velocity.magnitude < 40)
        {
            playerRb.AddForce(transform.forward * verticalInput * speed);
        }
        transform.Rotate(Vector3.up * horizontalInput*rotateSpeed);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Floor"){
            isGrounded = true;
        }   
    }
    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.name == "Floor"){
            isGrounded = false;
        }
    }
}