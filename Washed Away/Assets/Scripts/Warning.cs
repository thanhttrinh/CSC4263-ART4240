using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour {
	public GameObject warning;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			warning.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}

	}

	void OnTriggerExit2D(Collider2D other) {
		warning.gameObject.GetComponent<SpriteRenderer>().enabled = false;
	}
}
