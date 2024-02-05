using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor.U2D.Aseprite;
using UnityEditor.UIElements;
using UnityEngine;

public class Kolce : MonoBehaviour
{
    public Health health;
    
    public int ilosc_czasu_miedzy_obrazeniami;
    
    public int dmg;
    
    void Start()
    {
        dmg = 10;
        ilosc_czasu_miedzy_obrazeniami = 1000;
        
    }
    
    
    void OnTriggerEnter2D() {
        
        health.health = health.health - dmg;
        
    }
    
    
    
}
