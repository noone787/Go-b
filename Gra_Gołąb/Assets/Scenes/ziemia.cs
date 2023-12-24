using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;


public class ziemia : MonoBehaviour
{
    public bool IsOnGround = false;
    
    void OnCollisionEnter2D(){
        
        IsOnGround = true;
        
    }
    void OnCollisionExit2D(){
        
        IsOnGround = false;
        
    }
    
    
}
