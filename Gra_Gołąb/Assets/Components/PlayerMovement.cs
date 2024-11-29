using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5;
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
        }
        if (movement < 0)
        {   
            animator.SetBool("IsWalking", true);
            spriteRenderer.flipX = false;
        }
        else if (movement == 0) {
            animator.SetBool("IsWalking", false);
        }
        
        
    }
}
