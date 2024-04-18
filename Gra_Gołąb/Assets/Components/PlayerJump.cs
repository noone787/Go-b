using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerJump : MonoBehaviour
{

    // Rzeczy Do Skoku
    public float jumpforce = 20f;
    Rigidbody2D rb;
    public bool IsOnGround = false;
    public int AirJump = 1; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    
    // Faktyczny Skok

    void Update(){
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (IsOnGround == true){
                rb.AddForce(Vector2.up * jumpforce,ForceMode2D.Impulse);
            }
            else if (AirJump > 0){
                rb.AddForce(Vector2.up * jumpforce,ForceMode2D.Impulse);
                AirJump = AirJump - 1;
            }
            else{
                
            }
        }
    }
    
}
