using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;

public class Statystyki_Wyswietlacz : MonoBehaviour
{
    GameObject Staty;
    public void WyswietlenieStatystyk() {
        if (Input.GetMouseButton(1)) {
            Staty = new GameObject("Staty");
            Staty.transform.parent = transform;
            Staty.AddComponent<UnityEngine.UI.Image>();
            Staty.AddComponent<SpriteRenderer>();
        }
    }
    public void Wyjscie() {
        Staty.SetActive(false);
    }
    
}
