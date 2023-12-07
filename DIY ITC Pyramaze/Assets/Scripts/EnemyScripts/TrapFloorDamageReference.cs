using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFloorDamageReference : MonoBehaviour
{
    Animator animator;
    // public BoxCollider2D triggerBoxCollider;
    HealthBar healthbarnacle;
    PlayerHealth playerHealth;
    private bool isColliding = false;
    //public BoxCollider2D trapCollider;
    public BoxCollider2D trapHurter;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        healthbarnacle = GameObject.Find("Health Bar").GetComponent<HealthBar>();
        playerHealth = GameObject.Find("Protag-Kun_0").GetComponent<PlayerHealth>();
        // trapCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("TrapDoor Animation"))
        {
            // Player interaction with spike traps.




            if (isColliding)
            {
                // block player from walking through
                // get the collider

                // set is trigger to false
                trapHurter.isTrigger = false;
                // trapCollider.enabled = true;
                // make a return statement so that the is trigger doesn't damage the player twice (somehow)
                return;

            }

            if (other.gameObject.tag == "Player")

            {
                isColliding = true;
                playerHealth.playerCurrentHealth = playerHealth.playerCurrentHealth - 50;
                healthbarnacle.slider.value = playerHealth.playerCurrentHealth;
                StartCoroutine(Reset()); // I-frames.




            }


            // Slime interaction with spike traps.

            if (other.gameObject.tag == "Slime")
            {
                Destroy(other.gameObject);
            }

            // Spider interaction with spike traps.

            if (other.gameObject.tag == "Spider")
            {
                Destroy(other.gameObject);
            }
        }
        else
        {
            //trapCollider.enabled = false;
        }

    }

    // I-frames.

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(1.75f);
        isColliding = false;
        // get the collider
        // set is trigger to true
        trapHurter.isTrigger = true;
    }
}
