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
                            "null","null","null","null"   };
    String[] Lista_Mieczy = {"miecz1","miecz2"};
    String[] Lista_zbroi = {"armor1","armor2"};
    String[] Lista_pierscieni = {"pierscien1","pierscien2"};
    public string miecz;
    public string zbroja;
    public string pierscien1;
    public string pierscien2;

    public string dodanie_uzbrojenie;
    public string dodanie;
    
    
    public float max_zycie;
    public float zycie = 100;
    public int obrona = 0;
    public int atak = 10;
    void Start(){
        miecz = Inventory[19];
        zbroja = Inventory[18];
        pierscien1 = Inventory[16];
        pierscien2 = Inventory[17];
        dodanie = "null";
        dodanie_uzbrojenie = "null";
        max_zycie = zycie;
    }
    
    void Update() {
        if (dodanie != "null") {
            for (int i = 0;i < 16;i++) {
                if (Inventory[i] == "null") {
                    Inventory[i] = dodanie;
                    dodanie = "null";
                }
            }
        }
        if (dodanie_uzbrojenie != "null") {
            for (int i = 0;;i++) {
                if (Lista_Mieczy[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[19];
                    Inventory[19] = dodanie_uzbrojenie;
                    
                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_zbroi[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[18];
                    Inventory[18] = dodanie_uzbrojenie;
                    
                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_pierscieni[i] == dodanie_uzbrojenie) {
                    if (Inventory[17] == "null") {
                        dodanie = Inventory[17];
                        Inventory[17] = dodanie_uzbrojenie;
                        
                        dodanie_uzbrojenie = "null";
                    }
                    else if (Inventory[17] != "null"){
                        dodanie = Inventory[16];
                        Inventory[16] = dodanie_uzbrojenie;
                        
                        dodanie_uzbrojenie = "null";
                    }
                }
                else {

                }
            }
        }
        miecz = Inventory[19];
        zbroja = Inventory[18];
        pierscien1 = Inventory[16];
        pierscien2 = Inventory[17];

    }

}
