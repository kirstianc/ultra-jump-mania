using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheoAnimation : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //StartCoroutine(DieCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    IEnumerator DieCoroutine()
    {
        yield return new WaitForSeconds(3);
        animator.SetTrigger("Die");
        Destroy(gameObject, 1.5f);
    }
    
}
