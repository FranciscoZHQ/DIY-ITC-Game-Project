using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamageAnimationReference : MonoBehaviour
{
    Animator animator;
    // public BoxCollider2D triggerBoxCollider;
    HealthBar healthbarnacle;
    PlayerHealth playerHealth;
    private bool isColliding = false;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        healthbarnacle = GameObject.Find("Health Bar").GetComponent<HealthBar>();
        playerHealth = GameObject.Find("Protag-Kun_0").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Spike Animation"))
        {
            // Player interaction with spike traps.

            if (isColliding)
            {
                return;
            }

            if (other.gameObject.tag == "Player")

            {
                isColliding = true;
                playerHealth.playerCurrentHealth = playerHealth.playerCurrentHealth - 20;
                healthbarnacle.slider.value = playerHealth.playerCurrentHealth;
                StartCoroutine(Reset()); // I-frames.
            }


            // Slime interaction with spike traps.

            if (other.gameObject.tag == "Slime")
            {
                other.gameObject.GetComponent<MiniSlime>().makeSlimeDup();
                other.gameObject.GetComponent<MiniSlime>().makeSlimeDup();
                Destroy(other.gameObject);
            }

            // Spider interaction with spike traps.

            if (other.gameObject.tag == "Spider")
            {
                Destroy(other.gameObject);
            }
        }
    }

    // I-frames.

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(1.75f);
        isColliding = false;
    }
}
