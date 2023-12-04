using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerCurrentHealth;
    public int playerMaxHealth = 100;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    void Update()
    {
        if (Input.GetKey("h"))
        {
            heal();
        }
    }

    public void heal()
    {  
        if (playerCurrentHealth >= 80)
        {
            playerCurrentHealth = playerMaxHealth;
        }
        else
        {
            playerCurrentHealth += 20;
        }
    }
}
