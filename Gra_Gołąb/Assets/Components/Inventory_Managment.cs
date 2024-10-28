using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Inventory_Managment : MonoBehaviour
{   
    public UpgradeControl upgradeControl;
    public String[] Inventory = {  "null","null","null","null",
                                   "null","null","null","null",
                                   "null","null","null","null",
                                   "null","null","null","null",
                                };
    // miecze, zbroje, pierscienie PAMIETAC ABY W "IMAGE ITEM" TO ZMIENIAC "STATYSTYKI_WYSWIETLAC"
    public String[] Lista_Przedmiotów = {"miecz1","miecz2","armor1","armor2","pierscien1","pierscien2"};
    public int[] Lista_Przedmiotow_zycie = {0,0,10,30,10,0};
    public float[] Lista_Przedmiotow_atak= {10,15,0,0,0,5};
    public float[] Lista_Przedmiotow_obrona = {0,0,5,10,2,0};
    public float[] Lista_Przedmiotow_attack_speed= {1,0.5f,0,0,0.2f,0.3f};
    
    

    public string dodanie_uzbrojenie;
    public string dodanie;
    
    
    public float max_zycie;
    public float attack_speed = 0;
    public float zycie = 0;
    public float obrona = 0;
    public float atak = 0;
    // miecz
    public float attack_speed_dod;
    public float zycie_dod;
    public float obrona_dod;
    public float atak_dod;
    // zbroja 
    public float attack_speed_dod1;
    public float zycie_dod1;
    public float obrona_dod1;
    public float atak_dod1;
    // pierscien1
    public float attack_speed_dod2;
    public float zycie_dod2;
    public float obrona_dod2;
    public float atak_dod2;
    // pierscien2
    public float attack_speed_dod3;
    public float zycie_dod3;
    public float obrona_dod3;
    public float atak_dod3;
    

    void Start(){
        
        dodanie = "null";
        dodanie_uzbrojenie = "null";
        
    }
    
    void Update() {
        
        max_zycie = 100 + zycie_dod + zycie_dod1 + zycie_dod2 + zycie_dod3 + (upgradeControl.zycie_procent  * (100 + zycie_dod + zycie_dod1 + zycie_dod2 + zycie_dod3) );
        atak = atak_dod + atak_dod1 + atak_dod2 + atak_dod3 + (upgradeControl.atak_procent *(atak_dod + atak_dod1 + atak_dod2 + atak_dod3));
        obrona = obrona_dod + obrona_dod1 + obrona_dod2 + obrona_dod3 + (upgradeControl.obrona_procent  *(obrona_dod + obrona_dod1 + obrona_dod2 + obrona_dod3));
        attack_speed = attack_speed_dod + attack_speed_dod1 + attack_speed_dod2 + attack_speed_dod3 + (upgradeControl.attack_speed_procent  * 
        (attack_speed_dod + attack_speed_dod1 + attack_speed_dod2 + attack_speed_dod3));
        
    
        


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
                if (Lista_Przedmiotów[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[15];
                    Inventory[15] = dodanie_uzbrojenie;
                    
                    
                    
                    

                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_Przedmiotów[i] == dodanie_uzbrojenie) {
                    dodanie = Inventory[14];
                    Inventory[14] = dodanie_uzbrojenie;

                    
                    
                    
                    

                    dodanie_uzbrojenie = "null";
                }
                else if (Lista_Przedmiotów[i] == dodanie_uzbrojenie) {
                    if (Inventory[13] == "null") {
                        dodanie = Inventory[13];
                        Inventory[13] = dodanie_uzbrojenie;
                        
                        

                        dodanie_uzbrojenie = "null";
                    }
                    else if (Inventory[13] != "null"){
                        dodanie = Inventory[12];
                        Inventory[12] = dodanie_uzbrojenie;
                        
                        

                        dodanie_uzbrojenie = "null";
                    }
                }
                
            }
        }
        for (int i = 0;i < 7; i++) {
            if (Inventory[15] == Lista_Przedmiotów[i]) {
                attack_speed_dod = Lista_Przedmiotow_attack_speed[i];
                zycie_dod = Lista_Przedmiotow_zycie[i];
                obrona_dod = Lista_Przedmiotow_obrona[i];
                atak_dod = Lista_Przedmiotow_atak[i];
                
            }
            
            else if (Inventory[14] == Lista_Przedmiotów[i]) {
                attack_speed_dod1 = Lista_Przedmiotow_attack_speed[i];
                zycie_dod1 = Lista_Przedmiotow_zycie[i];
                obrona_dod1 = Lista_Przedmiotow_obrona[i];
                atak_dod1 = Lista_Przedmiotow_atak[i];
            }
            
            else if (Inventory[13] == Lista_Przedmiotów[i]) {
                attack_speed_dod2 = Lista_Przedmiotow_attack_speed[i];
                zycie_dod2 = Lista_Przedmiotow_zycie[i];
                obrona_dod2 = Lista_Przedmiotow_obrona[i];
                atak_dod2 = Lista_Przedmiotow_atak[i];
            }
            
            else if (Inventory[12] == Lista_Przedmiotów[i]) {
                attack_speed_dod3 = Lista_Przedmiotow_attack_speed[i];
                zycie_dod3 = Lista_Przedmiotow_zycie[i];
                obrona_dod3 = Lista_Przedmiotow_obrona[i];
                atak_dod3 = Lista_Przedmiotow_atak[i];
            }
                if (Inventory[15] == "null") {
                    attack_speed_dod = 0;
                    zycie_dod = 0;
                    obrona_dod = 0;
                    atak_dod = 0;
                }
            else if (Inventory[14] == "null") {
                    attack_speed_dod1 = 0;
                    zycie_dod1 = 0;
                    obrona_dod1 = 0;
                    atak_dod1 = 0;
                }
            else if (Inventory[13] == "null") {
                    attack_speed_dod2 = 0;
                    zycie_dod2 = 0;
                    obrona_dod2 = 0;
                    atak_dod2 = 0;
                }
            else if (Inventory[12] == "null") {
                    attack_speed_dod3 = 0;
                    zycie_dod3 = 0;
                    obrona_dod3 = 0;
                    atak_dod3 = 0;
                }
            if (zycie > max_zycie) {
                    zycie = max_zycie;
                }
            
        }
        
        

    }

}
