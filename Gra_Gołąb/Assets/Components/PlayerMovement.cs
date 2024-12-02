using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5;
    public bool Potrzebne_Do_Ataku = false;
    public Animator animator;
    public static bool PlayerDialogue = false;
    float movement;
    private SpriteRenderer spriteRenderer;
    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        
       

        if (!PlayerDialogue)
        {
        movement = Input.GetAxisRaw("Horizontal"); 
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        
        }
        if (movement > 0)
        {
            animator.SetBool("IsWalking", true);
            spriteRenderer.flipX = true;
            Potrzebne_Do_Ataku = true;
        }
        if (movement < 0)
        {   
            animator.SetBool("IsWalking", true);
            spriteRenderer.flipX = false;
            Potrzebne_Do_Ataku = false;
        }
        else if (movement == 0) {
            animator.SetBool("IsWalking", false);
        }
        
        
    }
}
