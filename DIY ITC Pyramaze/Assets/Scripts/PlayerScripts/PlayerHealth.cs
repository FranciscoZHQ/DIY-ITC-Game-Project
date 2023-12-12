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
        healthbarnacle = GameObject.Find("Health Bar").GetComponent<HealthBar>();
    }

    void Update()
    {
        
    }

    HealthBar healthbarnacle;
    public void heal()
    {
        if (playerCurrentHealth >= 80)
        {
            playerCurrentHealth = playerMaxHealth;
            healthbarnacle.slider.value = playerCurrentHealth;
        }
        else
        {
            playerCurrentHealth += 20;
            healthbarnacle.slider.value = playerCurrentHealth;
        }
    }
}
