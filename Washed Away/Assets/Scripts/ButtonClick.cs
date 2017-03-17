using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {
    private void OnMouseUp()
    {
        SceneManager.LoadScene("Sewer");
        //upon clicking the game object, change the scene
    }
}
