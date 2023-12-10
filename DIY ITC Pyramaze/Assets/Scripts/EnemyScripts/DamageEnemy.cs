using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{

    SpiderHealth health;
    SpiderHealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("Spider Enemy").GetComponent<SpiderHealth>();
        healthBar = GameObject.Find("Spider Health Bar").GetComponent<SpiderHealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
        // Interaction with spiders.

       
          if (Input.GetKey("j"))
          {
              health.spiderCurrentHealth = health.spiderCurrentHealth - 10;
              healthBar.slider.value = health.spiderCurrentHealth;
          }

       
        
          
    }
    

}

