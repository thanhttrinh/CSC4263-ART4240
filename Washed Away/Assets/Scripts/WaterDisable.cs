using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDisable : MonoBehaviour 
{
    private bool isJumping = true;
    public BoxCollider2D waterLane;

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
        yield return new WaitForSecondsRealtime(0.3f);
        waterLane.enabled = true;
    }
    

	
}
