using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Staty_Upgrade : MonoBehaviour
{
    public double dodatkowe_staty;
    public int co;
    // 1 to atak
    // 2 to zycie
    // 3 to obrona
    // 4 to attack_speed
    public UpgradeControl upgradeControl;
    private TMP_Text tMP_Text;
    void Start() {
        tMP_Text = GetComponent<TMP_Text>();
        tMP_Text.text = "0";
    }
    void Update() {
        if (co == 1) {
            dodatkowe_staty = upgradeControl.atak_procent;
            tMP_Text.text = dodatkowe_staty.ToString() + "%";
        }
        else if (co == 2) {
            dodatkowe_staty = upgradeControl.zycie_procent;
            tMP_Text.text = dodatkowe_staty.ToString() + "%";
        }
        else if (co == 3) {
            dodatkowe_staty = upgradeControl.obrona_procent;
            tMP_Text.text = dodatkowe_staty.ToString() + "%";
        }
        else if (co == 4) {
            dodatkowe_staty = upgradeControl.attack_speed_procent;
            tMP_Text.text = dodatkowe_staty.ToString() + "%";
        }
        
        
    }

}
