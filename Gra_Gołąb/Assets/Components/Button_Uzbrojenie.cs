using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Uzbrojenie : MonoBehaviour
{   
    public Inventory_Managment inventory_Managment;
    public Button button;
    

    void Start() {
        button.GetComponent<Button>();
    }
    public void ButtonClick_Uzbrojenie() {
        
        inventory_Managment.dodanie = GetComponentInParent<Uzbrojenie_Manager>().przedmiot2; 
        inventory_Managment.Inventory[GetComponentInParent<Uzbrojenie_Manager>().slot] = "null";
        
        
        }
}

