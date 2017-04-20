using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour {

	private GameObject player;
	private Vector3 prevPosition;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		prevPosition = player.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) 
		{
			other.gameObject.transform.position = new Vector3 (prevPosition.x, prevPosition.y, 0);
		}
	}
		
}
