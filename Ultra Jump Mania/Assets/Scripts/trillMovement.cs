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

    public void Move(float move)
	{
		Vector3 targetVelocity = new Vector2(move * 10f, 0);
		rb2d.velocity = targetVelocity;
	}
}
