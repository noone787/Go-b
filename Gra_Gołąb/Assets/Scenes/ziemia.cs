using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;


public class ziemia : MonoBehaviour
{
    public bool IsOnGround = false;
    public int AirJump = 1;
    void OnCollisionEnter2D(){
        AirJump = 1;
        IsOnGround = true;
        
    }
    void OnCollisionExit2D(){
        
        IsOnGround = false;
        
    }
    
    
}
