using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleDamageManager : MonoBehaviour
{
    PlayerHealth health;
    HealthBar healthBar;
    private bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBar>();
        health = GameObject.Find("Protag-Kun_0").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (isColliding)
        {
            return;
        }

        if (other.gameObject.tag == "Player")

        {
            isColliding = true;
            health.playerCurrentHealth = health.playerCurrentHealth - 15;
            healthBar.slider.value = health.playerCurrentHealth;
            StartCoroutine(Reset()); // I-frames.
        }
    }

    // I-frames.

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(1.75f);
        isColliding = false;
    }
}
