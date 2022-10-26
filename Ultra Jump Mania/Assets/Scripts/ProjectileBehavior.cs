using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.y == 0){
            transform.Translate(transform.right * Time.deltaTime * Speed);
        }else{
            transform.Translate(transform.right * Time.deltaTime * Speed * -1);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
