using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statystyki_Wyswietlacz : MonoBehaviour
{
    public Color color1;
    public Button button;
    public Color color2;
    void Update() {
        if (color1 == color2) {
            GameObject gameObject = new GameObject("aaa");
        }
    }
}
