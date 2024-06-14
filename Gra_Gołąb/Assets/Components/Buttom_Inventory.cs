using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttom_Inventory : MonoBehaviour
{
    public Button button;
    public int slot;
    public Slot_Manager slot_Manager;

    void Start() {
        button.GetComponent<Button>();
        slot = GetComponentInParent<Slot_Manager>().slot;
        
    }
    public void ButtonClick() {
        Debug.Log("sssssss");
    }
}
