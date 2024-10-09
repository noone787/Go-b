using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Health_Dissapearance : MonoBehaviour
{   
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Image image1;
    public UnityEngine.UI.Image image2;
    void Update () {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Q)) {
            image.enabled = !image.enabled;
            image1.enabled = !image1.enabled;
            image2.enabled = !image2.enabled;
        }
    }
}
