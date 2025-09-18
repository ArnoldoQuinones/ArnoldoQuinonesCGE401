/*
* Arnoldo "Arnie" Quinones
* Challenge 2
* Code Description: Indicating Dog Catching Ball
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScoreX displayScoreScript;
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("Dog").GetComponent<DisplayScoreX>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        //Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
