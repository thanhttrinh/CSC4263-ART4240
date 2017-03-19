using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

	private bool enter;
	private bool play;
	GameObject player;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); 
	}

	void Update()
	{
		if (enter) 
		{
			SceneManager.LoadScene("SewerPipes");
		}
		else if (play) 
		{
			SceneManager.LoadScene ("Sewer");
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject == player)
			enter = true;
	}

	//specifically for the menu play button
	void OnMouseUp()
	{
		play = true;
	}
}
