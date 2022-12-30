using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveF : MonoBehaviour
{
    public float speed;
    public Rigidbody rb1;
    float maxspeed = 50;

    
    void FixedUpdate()
    {
        
       speed += Time.fixedDeltaTime*0.5f;
        if (speed > maxspeed )
        {
            speed -= 10;
            print("speed");
            maxspeed+=5; 
        }
        Vector3 moveBack = -transform.forward * speed * Time.fixedDeltaTime;
        rb1.MovePosition(rb1.position + moveBack);
        
    }
}
