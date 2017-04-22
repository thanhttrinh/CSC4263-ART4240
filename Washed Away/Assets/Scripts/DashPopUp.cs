using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPopUp : MonoBehaviour 
{
	PopUpMenu dashShowing;
	private GameObject player;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		dashShowing = player.GetComponent<PopUpMenu> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) {
			dashShowing.dashShowing = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject == player) {
			dashShowing.dashShowing = false;
		}
	}
}
