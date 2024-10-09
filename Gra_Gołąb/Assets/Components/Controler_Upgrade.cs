using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler_Upgrade : MonoBehaviour
{   
    public Canvas canvas;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            canvas.enabled = !canvas.enabled;
        }
    }
}
