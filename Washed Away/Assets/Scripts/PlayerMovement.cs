using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	private CircleCollider2D cirlceCollider;
	private Rigidbody2D rigidBody;
	float movespeed = 2.0f;

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
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.up * movespeed * Time.deltaTime * 2.0f;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.left * movespeed * Time.deltaTime * 2.0f;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.down * movespeed * Time.deltaTime * 2.0f;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.right * movespeed * Time.deltaTime * 2.0f;
        }
    }
}
