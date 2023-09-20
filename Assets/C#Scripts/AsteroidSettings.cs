using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSettings : MonoBehaviour
{

    Rigidbody2D move;
    //public float maxAngularSpeed = 360.0f;
    //public float velocity;
    public float lifeTime;

    void Start()
    {
        move = GetComponent<Rigidbody2D>();

        //loat angularSpeed = maxAngularSpeed * velocity;

        // move.angularVelocity = angularSpeed;

        Destroy(gameObject, lifeTime);
    }


}
