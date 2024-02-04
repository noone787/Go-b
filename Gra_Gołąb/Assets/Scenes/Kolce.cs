using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Kolce : MonoBehaviour
{
    public Health health;
    public int dmg;
    BoxCollider2D boxCollider2D;
    public BoxCollider2D collider1;
    void Start()
    {
        dmg = 10;
    }
    
    void OnCollisionEnter2D(){
        Debug.Log("SDG");
        health.health = health.health - dmg;
        
    }
    
    void Update()
    {
        
    }
}
