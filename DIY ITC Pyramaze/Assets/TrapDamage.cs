using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : StateMachineBehaviour
{
    private BoxCollider2D triggerBoxCollider;
    private Animator animator;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       // Box collider turns on during this part of the animation.
        triggerBoxCollider.isTrigger = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Interactions with each enemy when the Box collider is active.
        if (triggerBoxCollider.isTrigger == true)
        {
            // Slime interaction with spike traps.
            if (other.gameObject.tag == "Slime")
            {
                Destroy(other.gameObject);
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       triggerBoxCollider.isTrigger = false;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
