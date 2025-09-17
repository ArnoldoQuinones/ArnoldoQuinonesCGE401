/*
* Arnoldo "Arnie" Quinones
* Prototype 2
* Code Description: Allows Player to Shoot Food
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    
    public GameObject prefabToShoot;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
