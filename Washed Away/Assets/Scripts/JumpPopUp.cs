using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPopUp : MonoBehaviour {

	PopUpMenu jumpShowing;
	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		jumpShowing = player.GetComponent<PopUpMenu> ();
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) {
			Debug.Log ("enter jump");
			jumpShowing.jumpShowing = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject == player) {
			Debug.Log ("exit jump");
			jumpShowing.jumpShowing = false;
		}
	}
}
