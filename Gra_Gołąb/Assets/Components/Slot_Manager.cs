using System.Collections;
using System.Collections.Generic;
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
        inventory_Managment.Inventory[slot] = miejsce;
    }
    
}
