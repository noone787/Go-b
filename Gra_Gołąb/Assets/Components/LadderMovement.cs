using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    public float vertical;
    private float climbSpeed = 8f;
    public bool nextToLadder;
    public bool isClimbing;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.W))
        {
            vertical = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            vertical = -1;
        }
        if (nextToLadder && vertical > 0)
        {
            isClimbing = true;
        }
    }

    void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * climbSpeed);
        }
        else
        {
            rb.gravityScale = 3f;
        }
    }
}
