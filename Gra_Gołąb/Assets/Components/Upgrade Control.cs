using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeControl : MonoBehaviour
{
    public int x;
    // 1 to atak
    // 2 to zycie
    // 3 to obrona
    // 4 to attack_speed
    public int zycie_procent;
    public double obrona_procent;
    public double atak_procent;
    public double attack_speed_procent;
    void Update() {
        if (x != 0) {
            if (x == 1) {
                atak_procent = atak_procent + 5;
                x = 0;

            }
            else if (x == 3) {
                obrona_procent = obrona_procent + 5;
                x = 0;
                
            }
            else if (x == 2) {
                zycie_procent = zycie_procent + 5;
                x = 0;
                
            }
            else if (x == 4) {
                attack_speed_procent = attack_speed_procent + 5;
                x = 0;
            }
        }
    }
}
