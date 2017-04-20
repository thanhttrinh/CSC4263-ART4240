using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneLoop : MonoBehaviour {

	private int counter;
	private bool enter;

	private BoxCollider2D trigger;
	public Vector3 prevPosition;
	public GameObject player;

	void Awake()
	{
		trigger = gameObject.GetComponent<BoxCollider2D> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		prevPosition = player.gameObject.transform.position;
	}

	void Update()
	{
		//once the player loop 3 times
		//the the collider will be disable
		if (enter) {
			trigger.enabled = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		counter++;

		if (counter <= 3) 
		{
			other.gameObject.transform.position = new Vector3 (prevPosition.x, prevPosition.y + 3.5f, 0);

			//for testing
			//other.gameObject.transform.position = new Vector3 (prevPosition.x, 55f, 0);

			enter = false;
		} 
		else 
		{
			enter = true;
		}

	}
}
