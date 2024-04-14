using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomDetector : MonoBehaviour
{
    public Health health;

    void OnTriggerEnter2D(){
        health.health = 0;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
