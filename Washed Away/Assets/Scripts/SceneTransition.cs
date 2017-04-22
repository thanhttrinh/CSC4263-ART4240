using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour {

	public bool enter;
	public bool play;
	public bool end;

	PopUpMenu gameOver;

	GameObject player;

	Scene currentScene;
	private string sceneName;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); 
		gameOver = player.GetComponent<PopUpMenu>();
		currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
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
		else if (end) 
		{
			gameOver.isDead = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) 
		{
			if (sceneName == "Sewer") 
			{
				enter = true;
			} 
			else if (sceneName == "Yard") 
			{
				end = true;
			}
		}
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
