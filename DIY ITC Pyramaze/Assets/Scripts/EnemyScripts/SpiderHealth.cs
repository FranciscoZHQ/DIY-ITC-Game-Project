using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderHealth : MonoBehaviour
{
    public int spiderCurrentHealth;
    public SpiderHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        spiderCurrentHealth = 100;

    }

    void Update()
    {
        // How the spider responds to damage and death.

        if (Input.GetKey("j")) // This makes a spider take damage as long as you
            // press "j". When someone does code in the combat system, please replace
            // this attack (but don't replace the code that contains
            // when the spider dies and anything below it.
        {
           spiderCurrentHealth = spiderCurrentHealth - 10;
            healthBar.slider.value = spiderCurrentHealth;
        }

        // When spider dies.
        if (spiderCurrentHealth <= 0)
        {
            KillSpider();
        }
    }

    public GameObject spider;
    public void KillSpider()
    {
        spider = GameObject.FindGameObjectWithTag("Spider");

        if (spider != null)
        {
            Destroy(spider.gameObject);
        }
    }

}

