using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool facingRight = true;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
        if(horizontalMove > 0 && !facingRight)
        {
            Flip();
            facingRight = true;
        }
        
        if (horizontalMove < 0 && facingRight)
        {
            Flip();
            facingRight = false;
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }

    // Flip
    
    private void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
    
    // Move our character
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
