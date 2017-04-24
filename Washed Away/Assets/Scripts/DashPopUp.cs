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
	//Once the player enters into a trigger, the DASH instruction is displayed
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) {
			dashShowing.dashShowing = true;
		}
	}
	//As soon as the player exit the trigger, the DASH instruction is disabled
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject == player) {
			dashShowing.dashShowing = false;
		}
	}
}
