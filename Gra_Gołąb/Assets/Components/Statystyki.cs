using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Statystyki : MonoBehaviour
{
    public TMP_Text tMP_Text;
    public Inventory_Managment inventory_Managment;
    public string co;
    public double atak;
    public double obrona;
    public double zycie;
    void Update() {
        
        
        
        if (co == "obrona") {
            tMP_Text.text = inventory_Managment.obrona.ToString();
        }
        else if (co == "atak") {
            tMP_Text.text = inventory_Managment.atak.ToString();
        }
        else if (co == "zycie") {
            tMP_Text.text = inventory_Managment.zycie.ToString();
        }
        else {
            tMP_Text.text = "error";
        }
        
    }
    
}
