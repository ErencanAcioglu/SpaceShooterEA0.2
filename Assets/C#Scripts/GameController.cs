using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameController : MonoBehaviour
{

    public GameObject asteroids;

    public int count;
    public float time;
    public float time2;
    public float startTime;

    public TextMeshProUGUI scoreText;
    public int score;

    public TextMeshProUGUI gameOver;
    private bool isGameOver = false;


    IEnumerator SpawnAsteroid()
    {
        while (true)
        {
            yield return new WaitForSeconds(startTime);
            for (int i = 0; i < count; i++)
            {
                Vector2 sPosition = new Vector2(Random.Range(-3, 3), 5.5f);
                Quaternion sRotation = Quaternion.identity;

                Instantiate(asteroids, sPosition, sRotation);

                yield return new WaitForSeconds(time);
            }
            yield return new WaitForSeconds(time2);
            if(isGameOver == true)
            {
                break;
            }
        }

    }
    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOver.text = "GAME OVER!";
        isGameOver = true;
    }


    void Start()
    {
        gameOver.text = "";
        isGameOver = false;
        StartCoroutine(SpawnAsteroid());
        
    }

    
   
}
