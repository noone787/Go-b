using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class Staty_Najechanie : MonoBehaviour
{
    public Zarzadzanie zarzadzanie;
    public TMP_Text tMP_Text;
    public string co;
    void Update() {
        if (co == "atak") {
            tMP_Text.text = zarzadzanie.staty_Najechanie_atak.ToString();
        }
        if (co == "obrona") {
            tMP_Text.text = zarzadzanie.staty_Najechanie_obrona.ToString();
        }
        if (co == "zycie") {
            tMP_Text.text = zarzadzanie.Staty_Najechanie_zycie.ToString();
        }
    }
}
