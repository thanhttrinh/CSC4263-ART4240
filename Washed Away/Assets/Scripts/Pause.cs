using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public bool gamePaused = false;	

	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gamePaused = true;
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            gamePaused = false;
            Time.timeScale = 1;
        }
    }
}
