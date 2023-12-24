using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.Serialization.Formatters;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerJump : MonoBehaviour
{

    // Rzeczy Do Skoku
    public float jumpforce = 10f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    public ziemia ziemia;

    // Faktyczny Skok

    void Update(){
        if (ziemia.IsOnGround == true && Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpforce,ForceMode2D.Impulse);
        }
    }
    
}
