using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderHealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int spiderHealth)
    {
        slider.maxValue = spiderHealth;
        slider.value = spiderHealth;
    }

    public void SetHealth(int spiderHealth)
    {
        slider.value = spiderHealth;
    }
}
