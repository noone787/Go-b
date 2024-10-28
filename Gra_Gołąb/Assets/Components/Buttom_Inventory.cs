using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttom_Inventory : MonoBehaviour
{
    public Button button;
    public Zarzadzanie zarzadzanie;
    private RectTransform rectTransform;
    public int slot;
    public string przedmiot1;
    
    
    
    public Inventory_Managment inventory_Managment;
    void Start() {
        button.GetComponent<Button>();
        
        przedmiot1 = GetComponentInParent<Inventory_Managment>().Inventory[slot];
        
        
        
    }
    void Update() {
        przedmiot1 = inventory_Managment.Inventory[slot];
        
    }
    public void ButtonClick() {
        
        if (inventory_Managment.Inventory[slot] != "null") {

            
                
                
            
            inventory_Managment.dodanie_uzbrojenie = inventory_Managment.Inventory[slot];
            inventory_Managment.Inventory[slot] = "null";
        }
        
        }
        public void zarzadzanie_click() {
            if (Input.GetMouseButton(1)) {
                zarzadzanie.co = inventory_Managment.Inventory[slot];
            }
        }

        

            
        }
        
    

