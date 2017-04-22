using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D rigidBody;

	private Vector2 lastMove;

	private CircleCollider2D cirlceCollider;
	public int DashSupply = 30;
	private float nextActionTime = 0f;
	public float period = 3f;

	public bool backKey;
	public bool movements;

	GameObject player;

	Scene cureentScene;
	private string sceneName;

	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		backKey = true;
		movements = true;

		player = GameObject.FindGameObjectWithTag ("Player");
		cureentScene = SceneManager.GetActiveScene ();
		sceneName = cureentScene.name;
	}

	void Update () 
	{
		rigidBody.velocity = new Vector2 (rigidBody.velocity.x, moveSpeed * Time.deltaTime);
		moveSpeed += 0.01f;
			//if A or D is pressed, a force will be applied in the Horizontal direction
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || 
			Input.GetAxisRaw ("Horizontal") < -0.5f) 
		{
			rigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, rigidBody.velocity.y);
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
		}
		// If force is between -0.5 and 0.5 then player will not move
		if (Input.GetAxisRaw ("Horizontal") < 0.5f && 
			Input.GetAxisRaw ("Horizontal") > -0.5f) 
		{
			rigidBody.velocity = new Vector2 (0f, rigidBody.velocity.y);
		}

		//JUMP
		if (Input.GetKey(KeyCode.D) &&
			Input.GetKey (KeyCode.Space)) 
		{
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x + 7.0f, rigidBody.velocity.y);
		}

		if (Input.GetKey(KeyCode.A) &&
			Input.GetKey (KeyCode.Space)) 
		{
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x - 7.0f, rigidBody.velocity.y);
		}

		//DASH
		if (sceneName == "Yard") {
			if (Input.GetKey (KeyCode.W) &&
			  Input.GetKey (KeyCode.LeftShift)) 
			{
				rigidBody.velocity = new Vector2 (rigidBody.velocity.x, rigidBody.velocity.y + 5.0f);
			}
		}

		//STOP THE PLAYER MOVEMENTS ALL TOGETHER
		if (movements == false) {
			rigidBody.velocity = new Vector2 (0f, rigidBody.velocity.y);
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0f);
		}
	}
}