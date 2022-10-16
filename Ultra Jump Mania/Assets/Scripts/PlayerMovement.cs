using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public ProjectileBehavior ProjectilePrefab;
    public Vector3 LaunchOffset;
    public float runSpeed = 40f;
    private Animator anim;
    private SpriteRenderer playerSpriteRenderer;
    private float horizontalMove = 0f;
    private bool jump = false;
    private bool facingRight = true;

    void Start() {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetBool("jump", true);
        }else{
            anim.SetBool("jump", false);
        }
        

        if(Input.GetAxisRaw("Horizontal") != 0){
            anim.SetBool("running", true);
            anim.Update(1f);
        }else{
            anim.SetBool("running", false);
        }
        /*
        if(horizontalMove > 0 && facingRight==false)
        {
            playerSpriteRenderer.flipX = false;
            facingRight = true;
        }
        
        if (horizontalMove < 0 && facingRight==true)
        {
            playerSpriteRenderer.flipX = true;
            facingRight = false;
        }
        */
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, transform.position+(-LaunchOffset), transform.rotation);
            /*
            if(facingRight){
                Instantiate(ProjectilePrefab, transform.position+LaunchOffset, transform.rotation);
            }else{
                Instantiate(ProjectilePrefab, transform.position+(-LaunchOffset), transform.rotation);
            }
            */
        }
    }
    
    // Move our character
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
