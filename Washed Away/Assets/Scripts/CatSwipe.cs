using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSwipe : MonoBehaviour {
	public GameObject paw;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			paw.gameObject.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
		}
	}
}
