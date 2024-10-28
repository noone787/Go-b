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
    public float zycie_procent;
    public float obrona_procent;
    public float atak_procent;
    public float attack_speed_procent;
    void Start() {
        zycie_procent = 0;
        obrona_procent = 0;
        atak_procent = 0;
        attack_speed_procent = 0;
    }
    void Update() {
        if (x != 0) {
            if (x == 1) {
                atak_procent = (atak_procent + 5)/100;
                x = 0;

            }
            else if (x == 3) {
                obrona_procent = (obrona_procent + 5)/100;
                x = 0;
                
            }
            else if (x == 2) {
                zycie_procent = (zycie_procent + 5)/100;
                x = 0;
                
            }
            else if (x == 4) {
                attack_speed_procent = (attack_speed_procent + 5)/100;
                x = 0;
            }
        }
    }
}
