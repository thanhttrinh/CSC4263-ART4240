using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSwipe : MonoBehaviour {
	public GameObject paw;
	public GameObject warning;

    public AudioClip WarningSound;
    public AudioClip CatS;

    void Start () {
		
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			warning.gameObject.GetComponent<SpriteRenderer>().enabled = true;
			paw.gameObject.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
            AudioSource.PlayClipAtPoint(WarningSound, transform.position);
            AudioSource.PlayClipAtPoint(CatS, transform.position);
        }
	}

	void OnTriggerExit2D(Collider2D other) {
		warning.gameObject.GetComponent<SpriteRenderer>().enabled = false;
	}
}
