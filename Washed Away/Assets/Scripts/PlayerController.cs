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

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		playerMoving = false;
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) 
		{
			rigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, rigidBody.velocity.y);
			playerMoving = true;
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
		}
		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f) 
		{
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime);
			playerMoving = true;
			lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
		}

		if (DashSupply >= 0)
		{
			if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
			{
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
			Debug.Log("DashSupply has been reset");
		}
	}
}
