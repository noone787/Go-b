using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ekwipunek_Canvas_Editor : MonoBehaviour

{
   public Canvas canvas;
   
    void Start() {
        canvas.GetComponent<Canvas>();
        
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) )  {
            canvas.enabled = !canvas.enabled;
        }
}
}
//(gameObject.activeSelf == false)