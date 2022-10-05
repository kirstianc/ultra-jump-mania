using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheoAnimation : MonoBehaviour
{

    private Animator th_animator;

    // Start is called before the first frame update
    void Start()
    {
        th_animator = GetComponent<Animator>();
        
        /*
        Enumerator waitFiveSeconds()
        {
            yield return new WaitForSeconds(5);
            th_animator.Play("Idle");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow)){
            th_animator.ResetTrigger("Idle");
            th_animator.SetTrigger("Walk");
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            th_animator.ResetTrigger("Idle");
            th_animator.SetTrigger("Crouch");
        }
        if(Input.GetKey(KeyCode.Space)){
            th_animator.ResetTrigger("Idle");
            th_animator.SetTrigger("Jump");
        }
    }
}
