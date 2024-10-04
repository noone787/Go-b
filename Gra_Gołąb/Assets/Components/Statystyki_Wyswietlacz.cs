using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;

public class Statystyki_Wyswietlacz : MonoBehaviour
{
    
    
    public Zarzadzanie zarzadzanie;
    string[] Lista_Przedmiotów = {"miecz1","miecz2","armor1","armor2","pierscien1","pierscien2"};
    int[] Lista_Przedmiotow_zycie = {0,0,10,30,10,0};
    double[] Lista_Przedmiotow_atak= {10,15,0,0,0,5};
    double[] Lista_Przedmiotow_obrona = {0,0,5,10,2,0};
    double[] Lista_Przedmiotow_attack_speed= {1,0.5,0,0,0.2,0.3};
    void Start() {
        
        

    }
    public void WyswietlenieStatystyk() {
        
        if (Input.GetMouseButton(1)) {
            
            for (int i = 0;i < 6;i++) {
                if (zarzadzanie.co == Lista_Przedmiotów[i]) {
                    //atak
                    zarzadzanie.staty_Najechanie_atak = Lista_Przedmiotow_atak[i];
                    //obrona
                    zarzadzanie.staty_Najechanie_obrona = Lista_Przedmiotow_obrona[i];
                    //zycie
                    zarzadzanie.Staty_Najechanie_zycie = Lista_Przedmiotow_zycie[i];
                    //attack_speed
                    zarzadzanie.Staty_Najechanie_attack_speed = Lista_Przedmiotow_attack_speed[i];
                }
                
            }
        }
    }
    public void Wyjscie() {
        //atak
        zarzadzanie.staty_Najechanie_atak = 0;
        //obrona
        zarzadzanie.staty_Najechanie_obrona = 0;
        //zycie
        zarzadzanie.Staty_Najechanie_zycie = 0;
        //attack_speed
        zarzadzanie.Staty_Najechanie_attack_speed = 0;
        zarzadzanie.co = "null";
    }
    
}
