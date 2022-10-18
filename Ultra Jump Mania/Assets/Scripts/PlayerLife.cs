using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private bool dead;
    
    private void Start()
    {
        anim = GetComponent<Animator>();    
        rb = GetComponent<Rigidbody2D>();
        //StartCoroutine(DeathCheckCoroutine());
        dead = false;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("insta_death")){
            Die();
        }
    }

    private void Die(){
        anim.SetTrigger("death");
        dead=true;
        rb.bodyType= RigidbodyType2D.Static;
    }

    private void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
/*
    private IEnumerator DeathCheckCoroutine(){
        if(dead){
            yield new WaitForSeconds(2f);
            RestartLevel();
        }
    }
    */
}
