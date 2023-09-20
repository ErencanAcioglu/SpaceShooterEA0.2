using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControl : MonoBehaviour
{
    public GameController gameController;
    public GameObject explosion1;
    public GameObject explosion2;

    public void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
       
        Instantiate(explosion1, transform.position, transform.rotation);

        if(other.tag == "Player")
        {
            Instantiate(explosion2, other.transform.position, other.transform.rotation);
            gameController.GameOver();
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(gameObject);

            gameController.UpdateScore();
        }

       
        
        
    }
}
