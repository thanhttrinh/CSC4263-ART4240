using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	Vector3 offset;

	void Start() 
	{
		//offset = transform.position - player.transform.position;

	}

	void LateUpdate() 
	{
		//transform.position = player.transform.position + offset;

		// camera is fixed on x-coordinate
		// follows player as player moves its y-coordinate
		transform.position = new Vector3(transform.position.x, player.transform.position.y + 0.5f, transform.position.z);
	}
}
