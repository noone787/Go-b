using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziemia_Przenikalna : MonoBehaviour
{

public double xx = 1.3;
public double yy = 0.7;
    
    Transform transform1;
    public Transform transform999;
    double x1;
    double y1;
    void Start()
    {   
        transform1 = GetComponent<Transform>();
        // Jeśli zmieniasz grubość przenikalnej platformy to tutaj x i y zmieniaj jeśli chcesz płynne przejście z góry na dół i na odwrót
        x1 = xx;
        y1 = yy;
    }
    
   
    void Update()
    {
        bool x = Input.GetKey(KeyCode.S);
        if (transform999.position.y > transform1.position.y + x1 && x != true ) {
            gameObject.layer = 0;
        }
        if (Input.GetKey(KeyCode.S)) {
            gameObject.layer = 1;
        }
        
        else if (transform999.position.y < transform1.position.y - y1) {
            gameObject.layer = 1;
        }
        

        
    }
}
