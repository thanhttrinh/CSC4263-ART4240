using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour 
{
	public GameObject pause;
	public GameObject jump;
	public GameObject dash;
	public GameObject gameover;

	private GameObject player;

	public bool jumpShowing;
	public bool dashShowing;
	public bool isDead;
	public bool pauseToggle = false;
	
	void Update ()
	{
		PauseMenu ();
		Jump ();
		GameOver ();
		Dash ();
	}
	//Toggles the pause menu using the ESC key
	void PauseMenu(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (pauseToggle) {
				Time.timeScale = 1.0f;
				pause.SetActive (false);
			} else {
				pause.SetActive (true);
				Time.timeScale = 0;
			}
			pauseToggle = !pauseToggle;
		}

	}
	//Display the GameOver UI
	void GameOver(){
		if (isDead == true) {
			gameover.SetActive (true);
		}
	}
	//Display the JUMP instruction UI
	void Jump(){
		if (jumpShowing == true) {
			jump.SetActive (true);
		} else {
			jump.SetActive (false);
		}
				
	}
	//Display the Dash instruction UI
	void Dash()
	{
		if (dashShowing == true) {
			dash.SetActive (true);
		} else {
			dash.SetActive (false);
		}
	}
		
}
