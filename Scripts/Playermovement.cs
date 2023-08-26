using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public Animator animator;

    public float RunSpeed = 40f;
    float HorizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
   

    void Update()
    {
        HorizontalMove = (Input.GetAxisRaw("Horizontal") * RunSpeed);
        animator.SetFloat("Speed", MathF.Abs(HorizontalMove));

        

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Jump", true);
            
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            animator.SetBool("Crouch", crouch);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void Onlanding()
    {
        animator.SetBool("Jump", false);
    }

    public void OnCrouching(bool Crouch)
    {
        animator.SetBool("Crouch", Crouch);
    }

    void FixedUpdate()
    {
        Controller.Move(HorizontalMove * Time.fixedDeltaTime, crouch , jump);
        jump = false;
    }
}