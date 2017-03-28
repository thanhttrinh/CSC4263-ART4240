using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static float moveSpeed;
	private Rigidbody2D rigidBody;

	private bool playerMoving;
	private Vector2 lastMove;

	private CircleCollider2D cirlceCollider;

	public bool backKey;

	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		backKey = true;
	}

	void Update () 
	{
		playerMoving = false;
		//if W or S is pressed, a force will be applied in the Horizontal direction
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) 
		{
			rigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, rigidBody.velocity.y);
			playerMoving = true;
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
		}
		//if A or D is pressed, a force will be applied in the Vertical direction
		if (Input.GetAxisRaw ("Vertical") > 0.5f || (Input.GetAxisRaw ("Vertical") < -0.5f && backKey == true)) 
		{
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime);
			playerMoving = true;
			lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
		}
		// If force is between -0.5 and 0.5 then player will not move
		if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f) 
		{
			rigidBody.velocity = new Vector2 (0f, rigidBody.velocity.y);
		}
		if (Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f) 
		{
			rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0f);
		}
	}
}
