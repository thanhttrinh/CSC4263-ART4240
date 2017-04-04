using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

	public int startHP = 100;	//player's starting hp
	public int currentHP;		//player's hp after being damaged
	bool playerHit = false;

	private PlayerController playerMovement;
	private GameObject player;

	private GameObject gameOver;

	void Start()
	{
		currentHP = startHP;
		player = GameObject.FindGameObjectWithTag ("Player"); 
		playerMovement = player.GetComponent <PlayerController>();	//get the player controller script
		gameOver = GameObject.Find ("GameOver");
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
			Debug.Log ("DMG TRIGGER : " + currentHP);
			playerHit = true;
			currentHP -= 25;
		}
	}

	//this function disable the player movement script
	void Death ()
	{
		playerMovement.movements = false;
		//playerMovement.enabled = false;
		//gameOver.gameObject.SetActive (true);
        //SceneManager.LoadScene("GameOver");
	}
}
