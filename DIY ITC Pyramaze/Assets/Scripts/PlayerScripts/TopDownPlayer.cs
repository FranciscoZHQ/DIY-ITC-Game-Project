
using System;
using UnityEngine;

public class TopDownPlayer : MonoBehaviour
{
    public float moveSpeed = 8.0f;

    public Boolean playerMove = true;

    Animator animator;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerMove)
        {
            // What Moves Us
            float horizontalInput = Input.GetAxis("Horizontal");

            //Get the value of the Horizontal input axis.
            float verticalInput = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
            //Move the object to XYZ coordinates defined as horizontalInput, verticalInput, and 0 respectively.

            //Animate
            if (horizontalInput > 0)
            {
                animator.SetBool("IsWalkingRight", false);
            }

            if (horizontalInput < 0)
            {
                animator.SetBool("IsWalkingLeft", false);
            }

            if (verticalInput > 0)
            {
                animator.SetBool("IsWalkingBackward", false);
            }

            if (verticalInput < 0)
            {
                animator.SetBool("IsWalkingForward", false);
            }

            if (horizontalInput > 0.1)
            {
                animator.SetBool("IsWalkingRight", true);
            }

            if (horizontalInput < -0.1)
            {
                animator.SetBool("IsWalkingLeft", true);
            }

            if (verticalInput > 0.1)
            {
                animator.SetBool("IsWalkingBackward", true);
            }

            if (verticalInput < -0.1)
            {
                animator.SetBool("IsWalkingForward", true);
            }
        }
        
    }
}
