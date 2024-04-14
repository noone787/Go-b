using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;


public class ziemia : MonoBehaviour
{
    public bool IsOnGround = false;
    public PlayerJump pj;
    public int AirJump = 1;
    void OnCollisionEnter2D(){
        pj.AirJump = 1;
        pj.IsOnGround = true;
        
    }
    void OnCollisionExit2D(){
        
        pj.IsOnGround = false;
        
    }
    
    
}
