using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TentacleCode : MonoBehaviour
{
    /*Animator animator;
    HealthBar healthbarnacle;
    PlayerHealth playerHealth;
    private bool isColliding = false;*/

    // Start is called before the first frame update
    void Start()
    {
        /*animator = GetComponent<Animator>();
        //healthbarnacle = GameObject.Find("Health Bar").GetComponent<HealthBar>();
        playerHealth = GameObject.Find("Protag-Kun_0").GetComponent<PlayerHealth>();*/

        StartCoroutine(waitKill());
        //Destroy(this.gameObject);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitKill()
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(this.gameObject);
    }

    /*private void OnTriggerStay2D(Collider2D other)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("TentacleB"))
        {
            if (isColliding)
            {
                return;
            }

            if (other.gameObject.tag == "Player")

            {
                isColliding = true;
                playerHealth.playerCurrentHealth = playerHealth.playerCurrentHealth - 20;
                healthbarnacle.slider.value = playerHealth.playerCurrentHealth;
                StartCoroutine(Reset());
            }
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(1.25f);
        isColliding = false;
    }*/
}
