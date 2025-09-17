/*
* Arnoldo "Arnie" Quinones
* Prototype 2
* Code Description: Controls Player Movement
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horiztonalInput;
    public float speed = 10.0f;
    private float xRange = 14;
    
    // Update is called once per frame
    void Update()
    {
        //Get horizontal input
        horiztonalInput = Input.GetAxis("Horizontal");
        
        //transform horizontally with our input
        transform.Translate(Vector3.right * horiztonalInput * Time.deltaTime * speed);
        
        //Keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
    }
}