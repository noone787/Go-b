using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Button_Upgrade : MonoBehaviour
{
    public LevelController levelController;
    public UpgradeControl upgradeControl;
    public int punkty;
    public int co;
    // 1 to atak
    // 2 to zycie
    // 3 to obrona
    // 4 to attack_speed
    void Start() {
        punkty = levelController.punkty_do_levelowania;
    }
    void Update() {
        punkty = levelController.punkty_do_levelowania;
    }
    public void Button1Click() {
        if (punkty != 0) {
            upgradeControl.x = co;
            levelController.punkty_do_levelowania = 0;
        }
    }
}
