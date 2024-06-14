using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot_Manager : MonoBehaviour
{
    public Inventory_Managment inventory_Managment;
    public int slot;
    public string miejsce;

    public int dodatkowe_zycie;
    public int obrona;
    public int atak = 10;
    void Start() {
        miejsce = inventory_Managment.Inventory[slot];
    }
    void Update () {
        inventory_Managment.Inventory[slot] = miejsce;
    }
    
}
