using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor_Manager : MonoBehaviour
{
    public string przedmiot2;
    public Inventory_Managment inventory_Managment;
    void Update() {
        switch (przedmiot2) {
            case "armor1": {
                inventory_Managment.dodatkowe_zycie = 10;
                inventory_Managment.obrona = 10;
                break;
            }
        }
    }
}
