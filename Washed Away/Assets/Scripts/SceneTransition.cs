using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour {

	public bool enter;
	public bool play;
	GameObject player;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); 
	}

	void Update()
	{
		if (enter) 
		{
			Scene ("Yard");
		} 
		else if (play) 
		{
			Scene ("Sewer");
		} 
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject == player)
			enter = true;
	}

	public void Scene(string scene){
		SceneManager.LoadScene (scene);
	}

	//specifically for the menu play button
	void OnMouseUp()
	{
		play = true;
	}

	public void Quit(){
		//this will quit the editor
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		Debug.Log ("QUIT");
		#endif
	}
}
