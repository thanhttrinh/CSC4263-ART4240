using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallTrigger : MonoBehaviour {
	public GameObject water1;
	public GameObject water2;
	public GameObject water3;

	private int counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		// the fly's warning sign should also be here

		if (other.gameObject.tag == "Player") {
			if (counter == 0) {
				water1.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				water1.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
			} else if (counter == 1) {
				water2.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				water2.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
			} else {
				water3.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				water3.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
			}
			counter++;
		}
	}
}
