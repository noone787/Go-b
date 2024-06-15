using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomDetector : MonoBehaviour
{
    public Inventory_Managment inventory_Managment;
    

    void OnTriggerEnter2D(){
        inventory_Managment.zycie = 0;
    }



    
}
