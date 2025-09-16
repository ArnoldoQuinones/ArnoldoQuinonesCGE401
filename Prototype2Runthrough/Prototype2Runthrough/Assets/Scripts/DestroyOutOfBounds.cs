using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;
    
    private HealthSystem healthSystemScript;
    
    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //if food goes out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        
        //if animals go out of bounds
        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");
            
            //grab the health system script and call TakeDamage()
            healthSystemScript.TakeDamage();
            
            Destroy(gameObject);
            
        }
    }
}
