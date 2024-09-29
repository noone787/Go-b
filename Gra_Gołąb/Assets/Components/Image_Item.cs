using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class Image_Item : MonoBehaviour
{
    
    [SerializeField] Sprite[] sprites;
    public Sprite sprite;
    string[] Lista_Przedmiotów = {"miecz1","miecz2","armor1","armor2","pierscien1","pierscien2"};
    public UnityEngine.UI.Image image;
    string przedmiot;
    void Start() {
        przedmiot = GetComponentInParent<Slot_Manager>().miejsce;
        
    }
    void Update() {
        przedmiot = GetComponentInParent<Slot_Manager>().miejsce;
        if (przedmiot != "null"){
            
            for (int i = 0;i < 6; i++) {
                
                if (przedmiot == Lista_Przedmiotów[i]) {
                    sprite = sprites[i];
                    image.enabled = true;
                    image.sprite = sprite;
                }
                else {

                }
            }
        }
        else if (przedmiot == "null") {
            image.enabled = false;
        }
        
        
    }
    
}
