using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallTrigger : MonoBehaviour {
	public GameObject water1;
	public GameObject water2;
	public GameObject water3;

	public GameObject foam1;
	public GameObject foam2;
	public GameObject foam3;

    public AudioClip WarningSound;
    public AudioClip WaterS;

	private int counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		// the fly's warning sign should also be here

		if (other.gameObject.tag == "Player") {
			if (counter == 0 && water1 != null && foam1 != null) {
				water1.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
				water1.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				water1.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
                AudioSource.PlayClipAtPoint(WarningSound, transform.position);
                AudioSource.PlayClipAtPoint(WaterS, transform.position);

				foam1.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				foam1.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
			} else if (counter == 1 && water2 != null && foam2 != null) {
				water2.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
				water2.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				water2.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
                AudioSource.PlayClipAtPoint(WarningSound, transform.position);
                AudioSource.PlayClipAtPoint(WaterS, transform.position);

                foam2.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				foam2.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
			} else if(counter == 2 && water2 != null && foam3 != null) {
				water3.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
				water3.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				water3.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
                AudioSource.PlayClipAtPoint(WarningSound, transform.position);
                AudioSource.PlayClipAtPoint(WaterS, transform.position);

                foam3.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				foam3.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.2f;
			}
			counter++;
		}
	}
}
