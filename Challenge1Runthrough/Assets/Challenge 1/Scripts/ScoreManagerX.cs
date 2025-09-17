/*
* Arnoldo "Arnie" Quinones
* Challenge 1
* Code Description: Indicates Player Win or Loss
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerX : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    
    public Text textbox;
    
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        //If the game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        
        //win condition: 5 or more points
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win!\nPress R to Try again!";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to Try again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
