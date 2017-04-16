using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour {

	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) 
		{
			Vector3 prevPosition = other.gameObject.transform.position;
			other.gameObject.transform.position = new Vector3 (prevPosition.x, -5.8f, 0);
		}
	}
		
}
