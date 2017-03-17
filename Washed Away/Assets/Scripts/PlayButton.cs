using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	public Sprite originalSprite;
	public Sprite newSprite;

	private SpriteRenderer spriteRenderer;

	bool click;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		if (spriteRenderer.sprite == null) {
			spriteRenderer.sprite = originalSprite;
		}
	}

	void Update()
	{
		if(Input.GetMouseButton(0)){
			SpriteChange ();
		}
	}

	void SpriteChange()
	{
		if (spriteRenderer.sprite == originalSprite) 
		{
			spriteRenderer.sprite = newSprite;
		} 
		else 
		{
			spriteRenderer.sprite = originalSprite;
		}
	}
}
