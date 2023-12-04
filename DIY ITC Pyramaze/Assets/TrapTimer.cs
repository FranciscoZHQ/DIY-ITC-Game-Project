using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTimer : MonoBehaviour
{
    public float trapTimer = 3.30f; // Before the trap can kill.
    public float killSwitch = 0.00001f; // When the trap can kill.
    public float blocker = 0f; // After the trap can kill, where it then acts like an obstacle.
    public float trapTimerTimeSetter = 3.30f;
    public float killSwitchTimeSetter = 0.00001f;
    public float blockerTimeSetter = 0f;

    public BoxCollider2D triggerBoxCollider;
    public BoxCollider2D blockerBoxCollider;
    public Rigidbody2D rigidBody2D;
    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        triggerBoxCollider.isTrigger = false;
        blockerBoxCollider.enabled = false;
        rigidBody2D.mass = 0;

        animator = GetComponent<Animator>();

    }

    public void RestartAnimation()
    {
        if (blocker <= 0f)
        {
            animator.Play("Spike Animation", -1, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // To tick down the first timer.

        trapTimer -= Time.deltaTime;

        if (trapTimer <= 0f)
        {
            // Move on to the next timer.
            killSwitch -= Time.deltaTime;
        }

        if (killSwitch <= 0f)
        {
            blocker -= Time.deltaTime;
        }

       
        // Makes the collision of the trap during the blocker phase turn on and off

        if (killSwitch <= 0f && blocker > 0f)
        {
           rigidBody2D.mass = 2;
        }
        else
        {
           rigidBody2D.mass = 0;
        }

        if (killSwitch <= 0f && blocker > 0f)
        {
           blockerBoxCollider.enabled = true;
        }
        else
        {
            blockerBoxCollider.enabled = false;
        }

        if (trapTimer <= 0f && killSwitch > 0f)
        {
            triggerBoxCollider.isTrigger = true;
            if (triggerBoxCollider.isTrigger == true)
            {
                // Insert code that makes the collider damage the player and enemies here.

            }
        }
        else
        {
            triggerBoxCollider.isTrigger = false;
        }

        if (blocker <= 0f)
        {

            // These need to equal each other for it to work good.

            trapTimer = trapTimerTimeSetter;
            killSwitch = killSwitchTimeSetter;
            blocker = blockerTimeSetter;
        }





    }
  
    /*private void OnTriggerEnter2D(Collider2D other)
    {

        // During the killSwitch, the boxCollider.isTrigger activates, damaging the player and killing enemies.

        if (trapTimer == 0f && killSwitch > 0f)
        {
            triggerBoxCollider.isTrigger = true;
            if (triggerBoxCollider.isTrigger == true)
            {
                // Insert code that makes the collider damage the player and enemies here.

            }
        }
        else
        {
            triggerBoxCollider.isTrigger = false;
        }
    } */
}
