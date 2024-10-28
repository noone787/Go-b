using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Uzbrojenie : MonoBehaviour
{   
    public Inventory_Managment inventory_Managment;
    public Zarzadzanie zarzadzanie;
    public Button button;
    public int slot;
    
    void Start() {
        button.GetComponent<Button>();
    }
    public void ButtonClick_Uzbrojenie() {
        
        inventory_Managment.dodanie = GetComponentInParent<Inventory_Managment>().Inventory[slot]; 
        
        inventory_Managment.Inventory[slot] = "null";
        
        
        }
        public void zarzadzanie_click() {
            if (Input.GetMouseButton(1)) {
                zarzadzanie.co = inventory_Managment.Inventory[slot];
            }
        }
}

