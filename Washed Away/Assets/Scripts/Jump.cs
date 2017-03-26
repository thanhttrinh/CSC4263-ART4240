using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    private bool isJumping = true;
    public BoxCollider2D waterLane;
    public Rigidbody2D player;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Jumping());
        }
    }

    IEnumerator Jumping()
    {
        waterLane.enabled = false;
        yield return new WaitForSecondsRealtime(0.8f);
        waterLane.enabled = true;
    }
    

	
}
