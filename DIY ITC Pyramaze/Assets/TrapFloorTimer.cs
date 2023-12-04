using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFloorTimer : MonoBehaviour
{
    public float trapTimer = 3.30f; // Before the trap can kill.
    public float killSwitch = 0.00001f; // When the trap can kill.
    public float trapTimerTimeSetter = 3.30f;
    public float killSwitchTimeSetter = 0.00001f;

    public BoxCollider2D triggerBoxCollider;
    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        triggerBoxCollider.isTrigger = false;
        animator = GetComponent<Animator>();
        PlayAnimation();

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

        if (killSwitch <= 0f)
        {

            // These need to equal each other for it to work good.

            trapTimer = trapTimerTimeSetter;
            killSwitch = killSwitchTimeSetter;
        }

      





    }

    void PlayAnimation()
    {
        animator.Play("TrapDoor Animation", -1, 0f);
    }

    public void StopAnimationLoop()
    {
        if (killSwitch >= 0f)
        {
            animator.StopPlayback();
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
