using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5;
    public static bool PlayerDialogue = false;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (!PlayerDialogue)
        {
        var movement = Input.GetAxisRaw("Horizontal"); 
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        }
    }
}
