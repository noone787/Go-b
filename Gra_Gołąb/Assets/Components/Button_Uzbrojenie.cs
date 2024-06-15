using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Uzbrojenie : MonoBehaviour
{   
    public Inventory_Managment inventory_Managment;
    public Button button;
    public string x;
    private bool prawda;

    void Start() {
        button.GetComponent<Button>();
    }
    public void ButtonClick_Uzbrojenie() {
        
        x = GetComponentInParent<Armor_Manager>().przedmiot2;
        
        if (x != "null") {
            for (int i = 0;prawda == true; i++) {
                if (inventory_Managment.Inventory[i] == "null") {
                    inventory_Managment.Inventory[i] = x;
                    prawda = false;
                }
                else if (i > 15){
                    prawda = false;
                }
                else {

                }
                    
            }
                
            }
        else {

        }
        prawda = true;
        }
}

