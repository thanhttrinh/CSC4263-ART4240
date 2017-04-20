using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingWaterDelete : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "RunningWater") {
			Destroy (other.gameObject);
		}
	}
}
