using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using Microsoft;
using TMPro;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Inventory_Managment inventory_Managment;
    float zycie_poczatkowe;
    public Transform gracz;
    public TextMeshProUGUI textMeshPro;
    public GameObject death_image;
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Image Play_Button_Image;
    public UnityEngine.UI.Image Options_Button_Image;
    public Button Play_Button;
    public Button Options_Button;
    public SpriteRenderer Main_Menu_SpriteRenderer;
    public Vector3 x;
    public float health;
    
    void Start(){
        health = inventory_Managment.zycie;
        zycie_poczatkowe = health;
        Vector3 x = gracz.position;
    }
    
    
    void Update(){
        health = inventory_Managment.zycie;
        image.fillAmount = health/inventory_Managment.max_zycie;
        if (health == 0) {
            death_image.SetActive(true);
            textMeshPro.enabled = false;
            gracz.position = x;
            if (health == zycie_poczatkowe) {
                death_image.SetActive(false);
                textMeshPro.enabled = true;
                gracz.position = x;
            }
        }
        

    }
}
