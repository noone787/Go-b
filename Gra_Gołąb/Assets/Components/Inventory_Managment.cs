using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;

public class Inventory_Managment : MonoBehaviour
{
    public String[] Inventory = {  "null","null","null","null",
                                   "null","null","null","null",
                                   "null","null","null","null",
                                   "null","null","null","null",
                                };
    // miecze, zbroje, pierscienie PAMIETAC ABY W "IMAGE ITEM" TO ZMIENIAC "STATYSTYKI_WYSWIETLAC"
    public String[] Lista_Przedmiotów = {"miecz1","miecz2","armor1","armor2","pierscien1","pierscien2"};
    public int[] Lista_Przedmiotow_zycie = {0,0,10,30,10,0};
    public Double[] Lista_Przedmiotow_atak= {10,15,0,0,0,5};
    public Double[] Lista_Przedmiotow_obrona = {0,0,5,10,2,0};
    public Double[] Lista_Przedmiotow_attack_speed= {1,0.5,0,0,0.2,0.3};
    public String[] Lista_Mieczy = {"miecz1","miecz2"};
    // statystyki (atak, attackspeed)
    public Double[] Stat_mieczy = {10,  15}; // atak
    public Double[] Stat_mieczy2 = {1,  0.5}; // attack_speed
    public String[] Lista_zbroi = {"armor1","armor2"};
    // statystyki (obrona, dodatkowy_health)
    public Double[] Stat_zbroi = {5,  10}; // obrona
    public int[] Stat_zbroi2 = {10,  30}; // dodatkowy_health
    public String[] Lista_pierscieni = {"pierscien1","pierscien2"};
    // statystyki (dodatkowy_health, obrona, atak, attack speed)
    
    public int[] Stat_pierscieni = {10,  0}; // dodatkowy_health
    public Double[] Stat_pierscieni2 = {2,  0}; // obrona
    public Double[] Stat_pierscieni3 = {0,  5}; // atak
    public Double[] Stat_pierscieni4 = {0.2,  0.3}; // attack_speed
    public string miecz;
    public string zbroja;
    public string pierscien1;
    public string pierscien2;

    public string dodanie_uzbrojenie;
    public string dodanie;
    
    
    public float max_zycie;
    public double attack_speed = 0;
    public float zycie = 100;
    public double obrona = 0;
    public double atak = 0;
    public double attack_speed_dod;
    public float zycie_dod;
    public double obrona_dod;
    public double atak_dod;
    public int x1;
    public int x2;
    public int x3;
    public int x4;

    void Start(){
        miecz = Inventory[15];
        zbroja = Inventory[14];
        pierscien1 = Inventory[13];
        pierscien2 = Inventory[12];
        dodanie = "null";
        dodanie_uzbrojenie = "null";
        max_zycie = zycie;
        zycie = 100;
    }
    
    void Update() {
        if (dodanie != "null") {
            for (int i = 0;i < 11;i++) {
                if (Inventory[i] == "null") {
                    Inventory[i] = dodanie;
                
        
                    dodanie = "null";
                }
            }
        }
        if (dodanie_uzbrojenie != "null") {
            for (int i = 0;i < 2;i++) {
                if (Lista_Mieczy[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[15];
                    Inventory[15] = dodanie_uzbrojenie;
                    
                    
                    
                    

                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_zbroi[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[14];
                    Inventory[14] = dodanie_uzbrojenie;

                    
                    
                    
                    

                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_pierscieni[i] == dodanie_uzbrojenie) {
                    if (Inventory[13] == "null") {
                        dodanie = Inventory[13];
                        Inventory[13] = dodanie_uzbrojenie;
                        
                        

                        dodanie_uzbrojenie = "null";
                    }
                    else if (Inventory[13] != "null"){
                        dodanie = Inventory[12];
                        Inventory[12] = dodanie_uzbrojenie;
                        
                        max_zycie = zycie + Stat_pierscieni[i];
                        zycie = zycie + Stat_pierscieni[i];
                        atak = atak + Stat_pierscieni2[i];
                        obrona = obrona + Stat_pierscieni3[i];
                        attack_speed = attack_speed + Stat_pierscieni4[i];

                        dodanie_uzbrojenie = "null";
                    }
                }
                else {

                }
            }
        }
        
        

        
        

    }

}
