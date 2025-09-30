using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    
    public PlayerController playerControllerScript;
    
    public bool won = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        
        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }
        
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        //Display score until game is over
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        
        //Loss Condition: Hit the obstacle
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again!";
        }
        
        //Win Condition: 10 points
        if (score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;
            
            //playerControllerScript.StopRunning();
            
            scoreText.text = "You Win!\nPress R to Try Again!";
        }
        
        //Press R to restart if game is over
        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
