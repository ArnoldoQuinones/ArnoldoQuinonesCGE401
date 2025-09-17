/*
* Arnoldo "Arnie" Quinones
* Prototype 2
* Code Description: Preventing Player from going Out of Bounds
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food projectile prefab
public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }
    
}
