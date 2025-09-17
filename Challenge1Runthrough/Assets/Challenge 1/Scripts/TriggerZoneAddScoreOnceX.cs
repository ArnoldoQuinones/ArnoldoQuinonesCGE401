/*
* Arnoldo "Arnie" Quinones
* Prototype 1
* Code Description: Adding Trigger Zone Points
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to a trigger zone
public class TriggerZoneAddScoreOnceX : MonoBehaviour
{
    private bool triggered = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManagerX.score++;
        }
    }
}
