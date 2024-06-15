using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzbrojenie_Manager : MonoBehaviour
{
    public string przedmiot2;
    public int slot;
    public Inventory_Managment inventory_Managment;
    void Start() {
        przedmiot2 = "null";
    }
    void Update() {
        przedmiot2 = inventory_Managment.Inventory[slot];
    }
}
