using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardS = 1000f; 
    public float speed = 500f;

    void Update()
    {
        rb.AddForce(0,0, forwardS * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }

    }
}
