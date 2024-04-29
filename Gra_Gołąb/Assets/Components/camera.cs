using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class camera : MonoBehaviour
{
    public GameObject player;
    private Camera maincamera;
    public BoxCollider2D boundBox;
    private Vector3 MinBounds;
    
    private Vector3 MaxBounds;

    private float halfHeight;
    
    private float halfWidth;
    void Start()
    {
        maincamera = GetComponent<Camera>();
        MinBounds = boundBox.bounds.min;
        
        MaxBounds = boundBox.bounds.max;
        halfHeight = maincamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
    }
    void Update()
    {
        if (transform.position != player.transform.position)
        {
            transform.position += new Vector3(
                player.transform.position.x - transform.position.x,
                player.transform.position.y - transform.position.y,
                0);
        }
        float clampedX = Mathf.Clamp(transform.position.x, MinBounds.x + halfWidth, MaxBounds.x - halfWidth);
        float clampedY = Mathf.Clamp(transform.position.y, MinBounds.y + halfHeight, MaxBounds.y - halfHeight);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
