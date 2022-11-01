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
        StartCoroutine(DeathCheckCoroutine());
        dead = false;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("insta_death")){
            Die();
        }
    }

    private void Die(){
        dead=true;
        anim.SetTrigger("death");
        rb.bodyType= RigidbodyType2D.Static;
        StartCoroutine(DeathCheckCoroutine());
    }

    private void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public bool getDead(){
        return dead;
    }

    IEnumerator DeathCheckCoroutine(){
        if(dead){
            yield return new WaitForSeconds(1);
            RestartLevel();
        }
    }
    
}
