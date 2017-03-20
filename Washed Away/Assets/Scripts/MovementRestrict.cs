using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRestrict : MonoBehaviour {
	//this script will disable the S key once the player enter a lane

	GameObject player;
	PlayerMovement playerMovement;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerMovement = player.GetComponent <PlayerMovement>();
	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) {
			playerMovement.backKey = false;
			//Debug.Log ("entered");
		}
	}
}
