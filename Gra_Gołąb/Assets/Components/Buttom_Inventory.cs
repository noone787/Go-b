using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttom_Inventory : MonoBehaviour
{
    public Button button;
    private RectTransform rectTransform;
    public int slot;
    public string[] przedmiot1;
    
    public Inventory_Managment inventory_Managment;
    void Start() {
        button.GetComponent<Button>();
        
        przedmiot1 = GetComponentInParent<Inventory_Managment>().Inventory;
        
        
    }
    void Update() {
        przedmiot1 = GetComponentInParent<Inventory_Managment>().Inventory;
    }
    public void ButtonClick() {
        if (przedmiot1[slot] != "null") {
            inventory_Managment.dodanie_uzbrojenie = przedmiot1[slot];
            inventory_Managment.Inventory[slot] = "null";
        }
        else {

        }
    }
}
