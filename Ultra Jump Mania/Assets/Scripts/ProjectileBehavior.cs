using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
