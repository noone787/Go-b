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
    string miecz;
    string zbroja;
    string pierscien1;
    string pierscien2;
    float max_zycie;
    double attack_speed;
    float zycie;
    double obrona;
    double atak;
    int x1;
    int x2;
    int x3;
    int x4;
    String[] Lista_Mieczy = {"miecz1","miecz2"};
    // statystyki (atak, attackspeed)
    Double[] Stat_mieczy = {10,  15}; // atak
    Double[] Stat_mieczy2 = {1,  0.5}; // attack_speed
    String[] Lista_zbroi = {"armor1","armor2"};
    // statystyki (obrona, dodatkowy_health)
    Double[] Stat_zbroi = {5,  10}; // obrona
    int[] Stat_zbroi2 = {10,  30}; // dodatkowy_health
    String[] Lista_pierscieni = {"pierscien1","pierscien2"};
    // statystyki (dodatkowy_health, obrona, atak, attack speed)
    
    int[] Stat_pierscieni = {10,  0}; // dodatkowy_health
    Double[] Stat_pierscieni2 = {2,  0}; // obrona
    Double[] Stat_pierscieni3 = {0,  5}; // atak
    Double[] Stat_pierscieni4 = {0.2,  0.3}; // attack_speed

    
    
    public Inventory_Managment inventory_Managment;
    void Start() {
        button.GetComponent<Button>();
        
        przedmiot1 = GetComponentInParent<Inventory_Managment>().Inventory[slot];
        
        
        
    }
    void Update() {
        przedmiot1 = inventory_Managment.Inventory[slot];
        Console.WriteLine(Lista_Mieczy[0]);
    }
    public void ButtonClick() {
        
        if (inventory_Managment.Inventory[slot] != "null") {

            
                for (int i = 0;i < 2; i++) {
                    if (przedmiot1 == Lista_Mieczy[i]) {
                        inventory_Managment.atak = inventory_Managment.atak + Stat_mieczy[i];
                        inventory_Managment.attack_speed = inventory_Managment.attack_speed + Stat_mieczy2[i];
                        inventory_Managment.x1 = i;
                        
                    }
                    if (Lista_zbroi[i] == inventory_Managment.Inventory[slot]) {
                        inventory_Managment.max_zycie = inventory_Managment.zycie + Stat_zbroi2[i];
                        inventory_Managment.zycie = inventory_Managment.zycie + Stat_zbroi2[i];
                        inventory_Managment.obrona = inventory_Managment.obrona + Stat_zbroi[i];
                        inventory_Managment.x2 = i;
                    }
                    if (Lista_pierscieni[i] == inventory_Managment.Inventory[slot]) {
                        inventory_Managment.max_zycie = inventory_Managment.zycie + Stat_pierscieni[i];
                        inventory_Managment.zycie = inventory_Managment.zycie + Stat_pierscieni[i];
                        inventory_Managment.atak = inventory_Managment.atak + Stat_pierscieni2[i];
                        inventory_Managment.obrona = inventory_Managment.obrona + Stat_pierscieni3[i];
                        inventory_Managment.attack_speed = inventory_Managment.attack_speed + Stat_pierscieni4[i];
                        inventory_Managment.x3 = i;
                    }
                    if (Lista_pierscieni[i] == inventory_Managment.Inventory[slot]) {
                        inventory_Managment.max_zycie = inventory_Managment.zycie + Stat_pierscieni[i];
                        inventory_Managment.zycie = inventory_Managment.zycie + Stat_pierscieni[i];
                        inventory_Managment.atak = inventory_Managment.atak + Stat_pierscieni2[i];
                        inventory_Managment.obrona = inventory_Managment.obrona + Stat_pierscieni3[i];
                        inventory_Managment.attack_speed = inventory_Managment.attack_speed + Stat_pierscieni4[i];
                        inventory_Managment.x4 = i;
                }
                else {

            }
                
            }
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
        
    

