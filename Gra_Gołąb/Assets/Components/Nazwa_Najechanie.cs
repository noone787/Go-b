using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Nazwa_Najechanie : MonoBehaviour
{
    public TMP_Text tMP_Text;
    public Zarzadzanie zarzadzanie;
    void Update() {
        if (zarzadzanie.co != "null") {
            tMP_Text.text = zarzadzanie.co;
        }
        
        else if (zarzadzanie.co == "null") {
            tMP_Text.text = "";
        }
    }
}
