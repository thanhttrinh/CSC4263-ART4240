using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLane : MonoBehaviour {
	
	void OnTriggerExit2D(Collider2D other)
	{
		Vector3 prevPosition = other.gameObject.transform.position;
		other.gameObject.transform.position = new Vector3 (prevPosition.x + 5, -8, 0);
	}
}
