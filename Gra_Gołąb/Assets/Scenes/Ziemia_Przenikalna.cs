using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziemia_Przenikalna : MonoBehaviour
{
    public Transform transform;
    Transform transform1;
    public float odległosc;
    public float poczatek;
    
    void Start()
    {   
        
        
    }
    
   
    void Update()
    {
        bool x = Input.GetKey(KeyCode.S);
        if (transform.position.y > poczatek+ odległosc && x != true ) {
            gameObject.layer = 0;
        }
        if (Input.GetKey(KeyCode.S)) {
            gameObject.layer = 1;
        }
        
        else if (transform.position.y < poczatek + odległosc - 0.5) {
            gameObject.layer = 1;
        }

        
    }
}
