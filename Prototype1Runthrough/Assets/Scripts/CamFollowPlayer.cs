/*
* Arnoldo "Arnie" Quinones
* Prototype 1
* Code Description: Command for Camera Player Follow
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    //drag the player onto this reference in the Inspector
    public GameObject player;
    
    private Vector3 offset = new Vector3(0, 5, -10);
    
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
