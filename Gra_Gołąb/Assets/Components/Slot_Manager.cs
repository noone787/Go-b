using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class Slot_Manager : MonoBehaviour
{
    public Inventory_Managment inventory_Managment;
    public int slot;
    public string miejsce;
   

    
    void Start() {
        miejsce = inventory_Managment.Inventory[slot];
        
    }
    void Update () {
        miejsce = inventory_Managment.Inventory[slot];
        
    
        
    }
    
}
