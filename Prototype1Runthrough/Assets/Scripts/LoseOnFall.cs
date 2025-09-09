/*
* Arnoldo "Arnie" Quinones
* Prototype 1
* Code Description: Indicates Loss from Fall
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

//attach this script to the player
public class LoseOnFall : MonoBehaviour
{
    //public Text textbox;
    
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            //textbox.text = "You Lose!";
            ScoreManager.gameOver = true;
        }
    }
}