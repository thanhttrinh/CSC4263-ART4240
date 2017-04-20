using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour {

	private GameObject player;
	private Vector3 prevPosition;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		prevPosition = player.gameObject.transform.position;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) 
		{
			other.gameObject.transform.position = new Vector3 (prevPosition.x, prevPosition.y - 2.0f, 0);
		}
	}
		
}
