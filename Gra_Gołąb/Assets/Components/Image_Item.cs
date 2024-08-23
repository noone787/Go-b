using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class Image_Item : MonoBehaviour
{
    public Inventory_Managment inventory_Managment;
    public Sprite image;
    
    public int slot;
    void Start() {
        slot = GetComponentInParent<Slot_Manager>().slot;
    }
    void Update() {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = image;
    }
}
