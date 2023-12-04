using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerCurrentHealth;
    public int playerMaxHealth = 100;

    public HealthBar healthBar;

    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        
    }

    void Update()
    {

       
    }
}
