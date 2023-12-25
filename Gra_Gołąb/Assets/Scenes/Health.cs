using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public UnityEngine.UI.Image image;
    void Start(){
        health = 100;
        
    }
    void Update(){
        image.fillAmount = health/100;
    }
}
