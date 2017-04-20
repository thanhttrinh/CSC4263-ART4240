using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallTrigger : MonoBehaviour {
	public GameObject water;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		//if(water.GetComponent<SpriteRenderer>.enabled == false)
		//	water.GetComponent<SpriteRenderer>.enabled = true;
		//water.GetComponent<Rigidbody2D>.gravityScale = 0.5;
	}
}
