using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    float zycie_poczatkowe;
    public Transform gracz;
    public TextMeshProUGUI textMeshPro;
    public UnityEngine.UI.Image you_died;
    public UnityEngine.UI.Image czarne_tło;
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Image Play_Button_Image;
    public UnityEngine.UI.Image Options_Button_Image;
    public Button Play_Button;
    public Button Options_Button;
    public SpriteRenderer Main_Menu_SpriteRenderer;
    public Vector3 x;
    void Start(){
        health = 100;
        zycie_poczatkowe = health;
        Vector3 x = gracz.position;
    }
    
    
    void Update(){
        image.fillAmount = health/100;
        if (health == 0) {
            czarne_tło.enabled = true;
            you_died.enabled = true;
            Time.timeScale = 0f;
            textMeshPro.enabled = false;
            if (Input.GetKeyDown(KeyCode.Space)) {
                health = zycie_poczatkowe;
                czarne_tło.enabled = false;
                you_died.enabled = false;
                textMeshPro.enabled = true;
                gracz.position = x;
            }
        }

    }
}
