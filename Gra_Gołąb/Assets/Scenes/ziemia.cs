using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ziemia : MonoBehaviour
{
    
    void OnControllerColliderHit(ControllerColliderHit hit){

        Rigidbody body = hit.collider.attachedRigidbody;
        if (body.useGravity == true){
            gameObject.GetComponent<PlayerJump>().IsOnGround = true;
        }
        else {
            gameObject.GetComponent<PlayerJump>().IsOnGround = false;
        }

    }
}
