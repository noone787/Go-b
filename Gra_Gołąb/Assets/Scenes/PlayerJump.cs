using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerJump : MonoBehaviour
{
    public bool IsOnGround = false;

    void Skok(){
        if (Input.GetKeyDown("w") && IsOnGround == true){
            Debug.Log("sdvsdfvsdfv");
        }
    }
    
}
