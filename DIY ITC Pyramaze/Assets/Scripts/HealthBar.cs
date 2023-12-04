using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}*/

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    PlayerHealth playerHealth;


    public void Start()
    {
        playerHealth = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerHealth>();
    }


    public void SetMaxHealth()
    {
        slider.maxValue = 100;
        slider.value = playerHealth.playerCurrentHealth;
    }

    public void SetHealth()
    {
        slider.value = playerHealth.playerCurrentHealth;
    }
}
