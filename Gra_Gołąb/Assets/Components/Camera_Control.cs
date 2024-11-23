using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public Transform target;
    public Vector2 offset;
    
    void Update()
    {
        transform.position = target.position * offset;
    }
}
