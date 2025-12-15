using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");

        if (playerGoal != null)
        {
            float distance = Vector3.Distance(transform.position, playerGoal.transform.position);

            int currentWave = 1;
            if (GameManagerX.instance != null)
                currentWave = GameManagerX.instance.currentWave;

            float desiredTime = 10f - (currentWave - 1) * 1f;
            desiredTime = Mathf.Max(desiredTime, 2f);

            Vector3 direction = (playerGoal.transform.position - transform.position).normalized;
            enemyRb.velocity = direction * (distance / desiredTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            if (GameManagerX.instance != null)
            {
                GameManagerX.instance.LoseGame();
            }
            
            Destroy(gameObject);
        }

    }

}