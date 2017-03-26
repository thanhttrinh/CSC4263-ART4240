using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
		playerMovement = player.GetComponent <PlayerMovement>();	//get the player movement script
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
		//Debug.Log (currentHP);
	}

	//this method detect when the player trigger a damage event
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) 
		{
			playerHit = true;
			currentHP -= 25;
		}
	}

	//this function disable the player movement script
	void Death ()
	{
		playerMovement.enabled = false;
        SceneManager.LoadScene("GameOver");
	}
}
