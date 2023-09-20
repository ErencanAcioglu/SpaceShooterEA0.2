using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{

    Rigidbody2D move;
    
    public int velocity;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float nextLaser;
    public float count; 

    public GameObject laser;
    public GameObject laserSpawn;

    public float laserLifetime;

    


    void Start()
    {
        move = GetComponent<Rigidbody2D>();
        
    }


    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        move.AddForce(movement*velocity);

        Vector3 position = new Vector3(Mathf.Clamp(move.position.x, minX, maxX), Mathf.Clamp(move.position.y, minY, maxY));

        move.position = position;
    }

    void Update()
    {
       
        if (Input.GetButton("Fire1") && Time.time > nextLaser )
        {
            nextLaser = Time.time + count;
            GameObject newLaser = Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);  

            Destroy(newLaser, laserLifetime);

           
        }
        
    }
}

