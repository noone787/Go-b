using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttom_Inventory : MonoBehaviour
{
    public Button button;
    private RectTransform rectTransform;
    public int slot;
    public string przedmiot1;
    
    public Inventory_Managment inventory_Managment;
    void Start() {
        button.GetComponent<Button>();
        slot = GetComponentInParent<Slot_Manager>().slot;
        przedmiot1 = GetComponentInParent<Slot_Manager>().miejsce;
        
        
    }
    void Update() {
        przedmiot1 = GetComponentInParent<Slot_Manager>().miejsce;
    }
    public void ButtonClick() {
        if (przedmiot1 != "null") {
            inventory_Managment.dodanie_uzbrojenie = przedmiot1;
            inventory_Managment.Inventory[GetComponentInParent<Slot_Manager>().slot] = "null";
        }
        else {

        }
    }
}
