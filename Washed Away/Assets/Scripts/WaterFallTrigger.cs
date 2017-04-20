using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallTrigger : MonoBehaviour {
	public GameObject water;
	//public GameObject water2;
	//public GameObject water3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			water.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			water.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
		}
	}
}
