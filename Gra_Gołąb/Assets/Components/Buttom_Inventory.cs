using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttom_Inventory : MonoBehaviour
{
    public Button button;
    public int slot;
    public string przedmiot1;
    public Slot_Manager slot_Manager;
    public Uzbrojenie uzbrojenie;

    void Start() {
        button.GetComponent<Button>();
        slot = GetComponentInParent<Slot_Manager>().slot;
        przedmiot1 = GetComponentInParent<Slot_Manager>().miejsce;
        
    }
    public void ButtonClick() {
        uzbrojenie.przedmiot = przedmiot1;
    }
}
