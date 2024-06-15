using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uzbrojenie: MonoBehaviour
{
    public string przedmiot;
    public Miecz_Manager miecz_Manager;
    public Armor_Manager armor_Manager;
    public pierścien_Manager pierścien_Manager;
    void Update() {
        switch (przedmiot) {
            case "armor1": {
                armor_Manager.przedmiot2 = przedmiot;
                break;
            }
                
            case "miecz1":{
                miecz_Manager.przedmiot2 = przedmiot;
                break;
            }
                
            case "pierścien1": {
                pierścien_Manager.przedmiot2 = przedmiot;
                break;
            }
        }
    }
    
}
