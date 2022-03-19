using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    // private GameObject player;
    private Health _playerHealth;

    private void Start()
    {
        _playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /** Version 1 Code */
        // Debug.Log("You died!");
        // SceneManager.LoadScene("SampleScene");

        /** Version 2 Code */
        // if (other.CompareTag("Player"))
        // {
        //     Debug.Log("You died!");
        //     SceneManager.LoadScene("SampleScene");
        // }
        
        /** Version 3 Code */
        // if (other.CompareTag("Player"))
        // {
        //     player.GetComponent<Movement>().Die();
        // }
        
    }
}
