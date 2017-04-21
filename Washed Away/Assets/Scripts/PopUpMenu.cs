using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour 
{
	public GameObject pause;
	private bool isShowing;
	private bool pauseToggle;

	// Use this for initialization
	void Start () 
	{
		Debug.Log (Time.timeScale);
		pauseToggle = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		PauseMenu ();
	}

	void PauseMenu(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (pauseToggle) {
				Time.timeScale = 1.0f;
			} else {
				isShowing = !isShowing;
				pause.SetActive (isShowing);
				Time.timeScale = 0;
				Debug.Log (Time.timeScale);
			}
			pauseToggle = !pauseToggle;
		}

	}
		
}
