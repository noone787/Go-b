using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Items_Manager : MonoBehaviour
{
    public Slot_Manager inventory_Managment;
    public int dodatkowe_zycie;
    public int obrona;
    public int atak = 10;
    public Button button;
    void Start() {
        int zycie = inventory_Managment.dodatkowe_zycie;
        int obrona = inventory_Managment.obrona;
        int atak = inventory_Managment.atak;
    }
    
}
