using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trillMovement : MonoBehaviour
{
    private Transform trilltr;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        trilltr = GetComponent<Transform>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(-.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Edge")||collision.gameObject.CompareTag("Default")||collision.gameObject.CompareTag("ground")||collision.gameObject.CompareTag("projectile")){
            Destroy(gameObject);
        }
    }

    public void Move(float move)
	{
		Vector3 targetVelocity = new Vector2(move * 6f, 0);
		rb2d.velocity = targetVelocity;
	}
}
