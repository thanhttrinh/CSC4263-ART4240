using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

	public static int startHP = 100;	//player's starting hp
	public static int currentHP;		//player's hp after being damaged

	private PlayerController playerMovement;
	private GameObject player;

	private Animator playerAnim;

	PopUpMenu gameOver;


	void Start()
	{
		currentHP = startHP;
		player = GameObject.FindGameObjectWithTag ("Player"); 
		playerMovement = player.GetComponent <PlayerController>();
		gameOver = player.GetComponent<PopUpMenu>();
		playerAnim = player.GetComponent<Animator> ();
	}

	void Update()
	{

	}

	//this function detect when the player trigger a damage event
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) 
		{
			currentHP -= 25;
			Debug.Log ("DMG TRIGGER : " + currentHP);

			if (currentHP == 75) 
			{
				Destroy (GameObject.Find ("Heart4"));
			}
			if (currentHP == 50) 
			{
				Destroy (GameObject.Find ("Heart3"));
			}
			if (currentHP == 25) 
			{
				Destroy (GameObject.Find ("Heart2"));
			}
			if (currentHP == 0) 
			{
				Destroy (GameObject.Find ("Heart"));
				Death ();
			}
		}
	}

	//this function disable the player movement script
	void Death ()
	{
		playerMovement.movements = false;
		playerAnim.enabled = false;
		gameOver.isDead = true;
	}
}
