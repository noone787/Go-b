using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Manager : MonoBehaviour
{
    public Inventory_Managment inventory_Managment;
    public int slot;
    public string miejsce;
    public int x = 1;
    public Sprite sprite;
    void Start() {
        miejsce = inventory_Managment.Inventory[slot];
        
    }
    void Update () {
        miejsce = inventory_Managment.Inventory[slot];
        if (x == 1) {
            Wyswietlanie_Zdjecia();
        }
        if (miejsce == "null") {
            x = 1;
        }
        if (miejsce != "null") {
            
        }
    }
    public void Wyswietlanie_Zdjecia() {
        
        
        
            GameObject gameObject = new GameObject("item");
            gameObject.transform.position = new Vector2(0,0);
            gameObject.transform.SetParent(transform, false);
            gameObject.AddComponent<CanvasRenderer>();
            UnityEngine.UI.Image image = gameObject.AddComponent<UnityEngine.UI.Image>();
            image.sprite = sprite;
            x = 0;
        
    }
    
}
