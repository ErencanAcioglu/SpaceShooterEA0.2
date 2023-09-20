using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{

    Rigidbody2D moveLaser;
    public float laserVelocity;
   
    void Start()
    {
        moveLaser = GetComponent<Rigidbody2D>();

        moveLaser.velocity = transform.up*laserVelocity;


    }


}
