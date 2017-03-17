using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public int startHP = 100;	//player's starting hp
	public int currentHP;		//player's hp after being damaged
	bool playerHit;

	PlayerMovement playerMovement;
	GameObject player;

	void Awake()
	{
		currentHP = startHP;
		player = GameObject.FindGameObjectWithTag ("Player");
		playerMovement = player.GetComponent <PlayerMovement>();
	}

	void Update()
	{
		if (playerHit) {
			if (currentHP <= 75 && currentHP > 50) {
				Destroy (GameObject.Find ("Heart4"));
			}
			else if (currentHP <= 50 && currentHP > 25) {
				Destroy (GameObject.Find ("Heart3"));
			}
			else if (currentHP <= 25 && currentHP > 0) {
				Destroy (GameObject.Find ("Heart2"));
			}
			else if (currentHP == 0) {
				Destroy (GameObject.Find ("Heart"));
				Death ();
			}
		}
		/*
		if (playerHit && currentHP <= 75) {
			Destroy (GameObject.Find("Heart4"));
		}
		if(playerHit == player && currentHP <= 50) {
			Destroy (GameObject.Find("Heart3"));
		}
		if (playerHit == player && currentHP <= 25) {
			Destroy (GameObject.Find("Heart2"));
		}
		if (playerHit == player && currentHP <= 0) {
			Destroy (GameObject.Find("Heart"));
			Death ();
		}
		*/
		Debug.Log (currentHP);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) 
		{
			playerHit = true;
			currentHP -= 25;
		}
	}

	void Death ()
	{
		playerMovement.enabled = false;		//disable script for player movement
	}
}
