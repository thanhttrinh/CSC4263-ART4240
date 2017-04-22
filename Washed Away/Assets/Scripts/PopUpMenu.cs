using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour 
{
	public GameObject pause;
	public GameObject jump;
	public GameObject gameover;

	private GameObject player;

	public bool jumpShowing;
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
			Debug.Log ("died");
			Time.timeScale = 0.5f;
		}
	}

	void Jump(){
		if (jumpShowing == true) {
			jump.SetActive (true);
		} else {
			jump.SetActive (false);
		}
				
	}
		
}
