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
	private bool isShowing;
	private bool pauseToggle;

	void Start () 
	{
		pauseToggle = false;
	}
	
	void Update ()
	{
		PauseMenu ();
		Jump ();
		GameOver ();
		Dash ();
	}

	void PauseMenu(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (pauseToggle) {
				Time.timeScale = 1.0f;
			} else {
				isShowing = !isShowing;
				pause.SetActive (isShowing);
				Time.timeScale = 0;
				//Debug.Log (Time.timeScale);
			}
			pauseToggle = !pauseToggle;
		}

	}

	void GameOver(){
		if (isDead == true) {
			gameover.SetActive (true);
		}
	}

	void Jump(){
		if (jumpShowing == true) {
			jump.SetActive (true);
		} else {
			jump.SetActive (false);
		}
				
	}

	void Dash()
	{
		if (dashShowing == true) {
			dash.SetActive (true);
		} else {
			dash.SetActive (false);
		}
	}
		
}
