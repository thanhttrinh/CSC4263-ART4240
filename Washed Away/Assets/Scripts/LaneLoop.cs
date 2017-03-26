using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneLoop : MonoBehaviour {

	private int counter;
	private bool enter;

	private BoxCollider2D trigger;

	void Awake()
	{
		trigger = gameObject.GetComponent<BoxCollider2D> ();
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
			Vector3 prevPosition = other.gameObject.transform.position;
			other.gameObject.transform.position = new Vector3 (prevPosition.x, -4.7f, 0);

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
