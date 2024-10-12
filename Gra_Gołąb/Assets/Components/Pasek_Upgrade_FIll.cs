using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasek_Upgrade_FIll : MonoBehaviour
{
    public UpgradeControl upgradeControl;
    public UnityEngine.UI.Image atak1;
    public UnityEngine.UI.Image obrona1;
    public UnityEngine.UI.Image health1;
    public UnityEngine.UI.Image attack_speed1;
    private float atak;
    private float obrona;
    private float health;
    private float attack_speed;
    void Update() {
        atak = upgradeControl.atak_procent/5;
        obrona = upgradeControl.obrona_procent/5;
        health = upgradeControl.zycie_procent/5;
        attack_speed = upgradeControl.attack_speed_procent/5;
        atak1.fillAmount = atak/4f;
        obrona1.fillAmount = obrona/4f;
        health1.fillAmount = health/4f;
        attack_speed1.fillAmount = attack_speed/4f;
    }
}
