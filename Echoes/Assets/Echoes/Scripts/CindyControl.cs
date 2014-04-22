using UnityEngine;
using System.Collections;

public class CindyControl : MonoBehaviour
{
	public float maxSpeed = .5f;				// The fastest the player can travel in the x axis.
	//public AudioClip[] jumpClips;			// Array of clips for when the player jumps.
	//public AudioClip[] taunts;				// Array of clips for when the player taunts.
	private Animator anim;					// Reference to the player's animator component.


	void Awake()
	{
		anim = transform.Find("Model").GetComponent<Animator>();
	}


	void Update()
	{
	}


	void FixedUpdate ()
	{
		// Cache the horizontal and vertical input.
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		Vector2 velocity = (new Vector2 (h,v)).normalized*maxSpeed;

		// The Speed animator parameter is set to the absolute value of the horizontal input.
		if (velocity.magnitude > maxSpeed * 0.20)
			anim.SetBool ("Walking", true);
		else
			anim.SetBool ("Walking", false);

		rigidbody2D.velocity = velocity;

		// If the input is moving the player right and the player is facing left...
		//if(h > 0 && !facingRight)
			// ... flip the player.
		//	Flip();
		// Otherwise if the input is moving the player left and the player is facing right...
		//else if(h < 0 && facingRight)
			// ... flip the player.
		//	Flip();
	}
	
	
	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		//facingRight = !facingRight;

		// Multiply the player's x local scale by -1.
		//Vector3 theScale = transform.localScale;
		//theScale.x *= -1;
		//transform.localScale = theScale;
	}
}
