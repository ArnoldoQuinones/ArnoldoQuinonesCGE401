/*
* Arnoldo "Arnie" Quinones
* Challenge 1
* Code Description: Indicates Loss from Fall
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

//attach this script to the player
public class LoseOnFallX : MonoBehaviour
{
    //public Text textbox;
    
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 80 || transform.position.y < -51)
        {
            //textbox.text = "You Lose!";
            ScoreManagerX.gameOver = true;
        }
    }
}