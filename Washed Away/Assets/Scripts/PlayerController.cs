using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D rigidBody;

	private bool playerMoving;
	private Vector2 lastMove;

	private CircleCollider2D cirlceCollider;
	public int DashSupply = 30;
	private float nextActionTime = 0f;
	public float period = 3f;

	public bool backKey;
	public bool movements;

	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		backKey = true;
		movements = true;
	}

	void Update () 
	{
		playerMoving = true;
		rigidBody.velocity = new Vector2 (rigidBody.velocity.x, moveSpeed * Time.deltaTime);
		moveSpeed += 0.1f;
			//if A or D is pressed, a force will be applied in the Horizontal direction
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {
			rigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, rigidBody.velocity.y);
			//playerMoving = true;
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
		}
		//if W or S is pressed, a force will be applied in the Vertical direction
		/*if (Input.GetAxisRaw ("Vertical") > 0.5f || (Input.GetAxisRaw ("Vertical") < -0.5f && backKey == true)) {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime);
			playerMoving = true;
			lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
		}*/
		// If force is between -0.5 and 0.5 then player will not move
		if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f) {
			rigidBody.velocity = new Vector2 (0f, rigidBody.velocity.y);
		}
		/*if (Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f) {
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0f);
		}*/

		//STOP THE PLAYER MOVEMENTS ALL TOGETHER
		if (movements == false) {
			rigidBody.velocity = new Vector2 (0f, rigidBody.velocity.y);
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0f);
		}

		if (DashSupply >= 0)
		{
			if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.LeftShift)) {
				transform.position += Vector3.up * moveSpeed * Time.deltaTime * 2.0f;
				DashSupply = DashSupply - 10;
			}
			if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
			{
				transform.position += Vector3.left * moveSpeed * Time.deltaTime * 2.0f;
				DashSupply = DashSupply - 10;
			}
			if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
			{
				transform.position += Vector3.down * moveSpeed * Time.deltaTime * 2.0f;
				DashSupply = DashSupply - 10;
			}
			if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
			{
				transform.position += Vector3.right * moveSpeed * Time.deltaTime * 2.0f;
				DashSupply = DashSupply - 10;
			}
		}
		if (Time.time > nextActionTime)
		{
			nextActionTime += period;
			DashSupply = 30;
			//Debug.Log("DashSupply has been reset");
		}

	}
}

