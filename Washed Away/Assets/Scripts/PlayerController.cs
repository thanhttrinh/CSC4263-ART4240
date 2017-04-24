using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D rigidBody;

	public bool backKey;
	public bool movements;

    private GameObject Heart4;
    private GameObject Heart3;
    private GameObject Heart2;

    Scene currentScene;
	private string sceneName;

	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		backKey = true;
		movements = true;

        Heart4 = GameObject.Find("Heart4");
        Heart3 = GameObject.Find("Heart3");
        Heart2 = GameObject.Find("Heart2");

        currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
	}

	void Update () 
	{
		rigidBody.velocity = new Vector2 (rigidBody.velocity.x, moveSpeed * Time.deltaTime);
		moveSpeed += 0.01f;
			//if A or D is pressed, a force will be applied in the Horizontal direction
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || 
			Input.GetAxisRaw ("Horizontal") < -0.5f) 
		{
			rigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, rigidBody.velocity.y);
		}
		// If force is between -0.5 and 0.5 then player will not move
		if (Input.GetAxisRaw ("Horizontal") < 0.5f && 
			Input.GetAxisRaw ("Horizontal") > -0.5f) 
		{
			rigidBody.velocity = new Vector2 (0f, rigidBody.velocity.y);
		}

		//JUMP
		if (Input.GetKey(KeyCode.D) &&
			Input.GetKey (KeyCode.Space)) 
		{
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x + 7.0f, rigidBody.velocity.y);
		}

		if (Input.GetKey(KeyCode.A) &&
			Input.GetKey (KeyCode.Space)) 
		{
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x - 7.0f, rigidBody.velocity.y);
		}

		//DASH
		if (sceneName == "Yard") {
			if (Input.GetKey (KeyCode.W) &&
			  Input.GetKey (KeyCode.LeftShift)) 
			{
				rigidBody.velocity = new Vector2 (rigidBody.velocity.x, rigidBody.velocity.y + 5.0f);
			}
		}

		//STOP THE PLAYER MOVEMENTS ALL TOGETHER
		if (movements == false) {
			rigidBody.velocity = new Vector2 (0f, rigidBody.velocity.y);
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, 0f);
		}
	}
    
    //Picks up health
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HealthPickUp"))
        {
            //Deletes the health pickup on contact
            other.gameObject.SetActive(false);

            if (Health.currentHP == 100)
                Health.currentHP += 0;
            if(Health.currentHP == 75)
            {
                Health.currentHP += 25;
                Heart4.SetActive(true); //Reactivates the heart on the HUD
            }
            if (Health.currentHP == 50)
            {
                Health.currentHP += 25;
                Heart3.SetActive(true);
            }
            if (Health.currentHP == 25)
            {
                Health.currentHP += 25;
                Heart2.SetActive(true);
            }
        }
    }
}