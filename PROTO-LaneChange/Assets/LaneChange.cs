using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneChange : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		other.gameObject.transform.position = new Vector3(-2,-4,0);
	}
}
