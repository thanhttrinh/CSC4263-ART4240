using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	public Animator player;
	public KeyCode run;
	public KeyCode jump;
	public KeyCode left;
	public KeyCode right;
	
	void Update()
	{
		//if W is pressed, PlayerRun animation will play
		if (Input.GetKeyDown (run)) 
		{
			player.SetBool("PlayerRun", true);
		}
		//if W is released, PlayerRun animation will stop
		if (Input.GetKeyUp (run)) {
			player.SetBool ("PlayerRun", false);
		}

		if (Input.GetKeyDown (jump)) 
		{
			if(Input.GetKeyDown(right))
			{
				player.SetTrigger ("PlayerJump");
			}
			else if (Input.GetKeyDown (left)) {
				player.SetTrigger ("PlayerJump");
			}
		}
	}
}

