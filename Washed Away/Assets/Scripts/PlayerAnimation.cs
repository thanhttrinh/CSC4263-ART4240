using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	public Animator player;
	public KeyCode jump;
	public KeyCode left;
	public KeyCode right;
	
	void Update()
	{
		if (Input.GetKeyDown (jump)) {
			if (Input.GetKeyDown (right)) {
				player.SetBool ("PlayerJump", true);
			} else if (Input.GetKeyDown (left)) {
				player.SetBool ("PlayerJump", true);
			}
		}
		else 
		{
			player.SetBool ("PlayerJump", false);
		}
	}
}

