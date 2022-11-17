using UnityEngine;
using System.Collections;

/*
 * basic 2D character controller
 * use array keys / WASD to move object up/down/left/right
 */
public class Player2Move : MonoBehaviour
{
	// change speed
	public float speed = 10;

	// cached reference to a physics RigidBody
	private Rigidbody2D rigidBody2D;

	// the new velocity based on inputs
	private Vector2 newVelocity;

	//--------------------------
	// get reference tot the RigidBody 2D compoonent
	// that is in the parent GameObject to which an instance of this script has been added
	void Awake()
	{
		rigidBody2D = GetComponent<Rigidbody2D>();
	}

	//---------------------------
	void Update()
	{
		float xMove = Input.GetAxis("Horizontal2");
		float yMove = Input.GetAxis("Vertical2");
		
		// mutliple by speed factor
		float xSpeed = xMove * speed;
		float ySpeed = yMove * speed;

		// create (dx,dy) vector object
		newVelocity = new Vector2(xSpeed, ySpeed);
	}
	
	//---------------------------
	void FixedUpdate()
	{
		// set the velocity of the Physicsl rigid body to this (x,y) vector
		rigidBody2D.velocity = newVelocity;
	}
}
