using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] int cubbieDeathCount;
    [NonSerialized]
    public static GameManager gameManager;
    
    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (gameManager != this)
        {
            Destroy(this.gameObject);
        }
    }

    public void IncCubbieCount()
    {
        cubbieDeathCount += 1;
    }
    
}
