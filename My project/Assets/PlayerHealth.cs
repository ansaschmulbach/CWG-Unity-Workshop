using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] private int _health;
    [SerializeField] private int StartHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        _health = StartHealth;
    }

    // returns health
    public int GetHealth()
    {
        return _health;
    }

    // sets current health to amount, if health is <= 0 --> die
    public void SetHealth(int amount)
    {
        _health = amount;
        if (_health <= 0)
        {
            Die();
        }
    }

    // add amount to current health, if health is <= 0 --> die
    public void AddHealth(int amount)
    {
        _health += amount;
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GameManager.gameManager.IncCubbieCount();
        Debug.Log("You Died");
        SceneManager.LoadScene("SampleScene");
    }
    
}
