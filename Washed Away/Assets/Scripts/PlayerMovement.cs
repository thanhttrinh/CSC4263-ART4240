using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	private CircleCollider2D cirlceCollider;
	private Rigidbody2D rigidBody;
	float movespeed = 2.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
		{
			transform.position += Vector3.up * movespeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += Vector3.left * movespeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
			transform.position += Vector3.down * movespeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			transform.position += Vector3.right * movespeed * Time.deltaTime;
		}
		//if player hold space and D, the game object will jump right
		if (Input.GetKeyDown (KeyCode.D) && Input.GetKeyDown (KeyCode.Space)) 
		{
			
		}
		//if player hold space and A, the game object will jump left
		if (Input.GetKeyDown (KeyCode.D) && Input.GetKeyDown (KeyCode.Space)) 
		{

		}
	
	}
}
