using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneChange : MonoBehaviour {
	

	void OnTriggerEnter2D(Collider2D other)
	{
		Vector3 prevPosition = other.gameObject.transform.position;
		other.gameObject.transform.position = new Vector3(prevPosition.x+4,-4,0);
	}
}
