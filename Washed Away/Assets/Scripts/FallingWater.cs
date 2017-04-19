using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingWater : MonoBehaviour {
	public GameObject runningWater;

	Vector3 previousPosition;
	Vector3 currentPosition;

	// Use this for initialization
	void Start () {
		previousPosition = runningWater.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	// Trigger to reset falling water asset
	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "RunningWater") {
			runningWater.transform.position = previousPosition;
		}
	}
}
