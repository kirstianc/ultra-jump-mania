using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
	[SerializeField] private float jumpPower = 400f;
	[Range(0, .3f)] [SerializeField] private float movementSmoothing = .05f;
	[SerializeField] private Transform groundCheck;						

	private bool onGround;
	private Rigidbody2D rb2d;
	private bool facingRight = true;
	private Vector3 velocity = Vector3.zero;

	private void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		bool wasGrounded = onGround;
		onGround = false;
	}

	// move function
	public void Move(float move, bool jump){
		Vector3 targetVelocity = new Vector2(move * 4.5f, rb2d.velocity.y);
		rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, targetVelocity, ref velocity, movementSmoothing);
		
		if(move > 0 && !facingRight){
			Flip();
		}
		else if(move < 0 && facingRight){
			Flip();
		}

		if(jump){
			onGround = false;
			rb2d.AddForce(new Vector2(0f, jumpPower));
		}
	}

	// getter function to provide private facingRight bool
	public bool getFacingRight(){
		return facingRight;
	}

	// flips character
	private void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
