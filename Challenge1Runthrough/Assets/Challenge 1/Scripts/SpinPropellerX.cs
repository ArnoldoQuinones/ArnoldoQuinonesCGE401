/*
* Arnoldo "Arnie" Quinones
* Challenge 1
* Code Description: Command for Propeller Spin Speed
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
