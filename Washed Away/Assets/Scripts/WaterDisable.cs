using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDisable : MonoBehaviour 
{
    public BoxCollider2D waterLane;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Jumping());
        }
    }

    //Disables the water lane after spacebar is pressed, simulating a jump
    IEnumerator Jumping()
    {
        waterLane.enabled = false;
        yield return new WaitForSecondsRealtime(.3f);
        waterLane.enabled = true;
    }
    

	
}
