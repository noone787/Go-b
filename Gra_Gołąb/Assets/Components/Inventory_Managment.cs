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
    String[] Lista_Mieczy = {"miecz1","miecz2"};
    // statystyki (atak, attackspeed)
    Double[] Stat_mieczy = {10,  15};
    Double[] Stat_mieczy2 = {1,  0.5};
    String[] Lista_zbroi = {"armor1","armor2"};
    // statystyki (obrona, dodatkowy_health)
    Double[] Stat_zbroi = {5,  10};
    int[] Stat_zbroi2 = {10,  30};
    String[] Lista_pierscieni = {"pierscien1","pierscien2"};
    // statystyki (dodatkowy_health, obrona, atak, attack speed)
    
    int[] Stat_pierscieni = {10,  0};
    Double[] Stat_pierscieni2 = {2,  0};
    Double[] Stat_pierscieni3 = {0,  5};
    Double[] Stat_pierscieni4 = {0.2,  0.3};
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
            for (int i = 0;;i++) {
                if (Lista_Mieczy[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[15];
                    Inventory[15] = dodanie_uzbrojenie;
                    
                    
                    atak = atak + Stat_mieczy[i];
                    attack_speed = attack_speed + Stat_mieczy2[i];

                    

                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_zbroi[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[14];
                    Inventory[14] = dodanie_uzbrojenie;

                    
                    
                    max_zycie = zycie + Stat_zbroi2[i];
                    zycie = zycie + Stat_zbroi2[i];
                    obrona = obrona + Stat_zbroi[i];
                    

                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_pierscieni[i] == dodanie_uzbrojenie) {
                    if (Inventory[13] == "null") {
                        dodanie = Inventory[13];
                        Inventory[13] = dodanie_uzbrojenie;
                        
                        max_zycie = zycie + Stat_pierscieni[i];
                        zycie = zycie + Stat_pierscieni[i];
                        atak = atak + Stat_pierscieni2[i];
                        obrona = obrona + Stat_pierscieni3[i];
                        attack_speed = attack_speed + Stat_pierscieni4[i];

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
        
        




        miecz = Inventory[15];
        zbroja = Inventory[14];
        pierscien1 = Inventory[13];
        pierscien2 = Inventory[12];
        

    }

}
