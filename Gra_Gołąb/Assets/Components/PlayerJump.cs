using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerJump : MonoBehaviour
{

    // Rzeczy Do Skoku
    public float jumpforce = 8f;
    public float secondjumpforce = 10f;
    Rigidbody2D rb;
    public bool IsOnGround = false;
    public int AirJump = 1; 

    // Sound effect
    public AudioSource audioSource;
    public AudioClip sfx1;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource.clip = sfx1;
        
    }
    
    
    // Faktyczny Skok

    public void Update(){
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (IsOnGround == true){
                rb.AddForce(Vector2.up * jumpforce,ForceMode2D.Impulse);
                audioSource.Play();
            }
            else if (AirJump > 0){
                rb.velocity = Vector2.up * jumpforce;
                audioSource.Play();
                AirJump--;
            }
            else{
                
            }
        }
    }

    
}
