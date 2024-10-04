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
        if (slot == 15 && inventory_Managment.Inventory[15] != "null") {
            inventory_Managment.atak = inventory_Managment.atak - inventory_Managment.Stat_mieczy[inventory_Managment.x1];
            inventory_Managment.attack_speed = inventory_Managment.attack_speed - inventory_Managment.Stat_mieczy2[inventory_Managment.x1];
        }
        else if (slot == 14 && inventory_Managment.Inventory[14] != "null") {
            inventory_Managment.obrona = inventory_Managment.obrona - inventory_Managment.Stat_zbroi[inventory_Managment.x2];
            inventory_Managment.zycie = inventory_Managment.zycie - inventory_Managment.Stat_zbroi2[inventory_Managment.x2];
            inventory_Managment.max_zycie= inventory_Managment.max_zycie - inventory_Managment.Stat_zbroi2[inventory_Managment.x2];
        }
        else if (slot == 13 && inventory_Managment.Inventory[13] != "null") {
            inventory_Managment.obrona = inventory_Managment.obrona - inventory_Managment.Stat_pierscieni2[inventory_Managment.x3];
            inventory_Managment.zycie = inventory_Managment.zycie - inventory_Managment.Stat_pierscieni[inventory_Managment.x3];
            inventory_Managment.max_zycie = inventory_Managment.max_zycie - inventory_Managment.Stat_pierscieni[inventory_Managment.x3];
            inventory_Managment.atak = inventory_Managment.atak - inventory_Managment.Stat_pierscieni3[inventory_Managment.x3];
            inventory_Managment.attack_speed = inventory_Managment.attack_speed - inventory_Managment.Stat_pierscieni4[inventory_Managment.x3];
        }
        else if (slot == 12 && inventory_Managment.Inventory[12] != "null") {
            inventory_Managment.obrona = inventory_Managment.obrona - inventory_Managment.Stat_pierscieni2[inventory_Managment.x4];
            inventory_Managment.zycie = inventory_Managment.zycie - inventory_Managment.Stat_pierscieni[inventory_Managment.x4];
            inventory_Managment.max_zycie = inventory_Managment.max_zycie - inventory_Managment.Stat_pierscieni[inventory_Managment.x4];
            inventory_Managment.atak = inventory_Managment.atak - inventory_Managment.Stat_pierscieni3[inventory_Managment.x4];
            inventory_Managment.attack_speed = inventory_Managment.attack_speed - inventory_Managment.Stat_pierscieni4[inventory_Managment.x4];
        }
        inventory_Managment.Inventory[slot] = "null";
        
        
        }
        public void zarzadzanie_click() {
            if (Input.GetMouseButton(1)) {
                zarzadzanie.co = inventory_Managment.Inventory[slot];
            }
        }
}

