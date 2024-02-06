using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor.U2D.Aseprite;
using UnityEditor.UIElements;
using UnityEngine;

public class Kolce : MonoBehaviour
{
    public Health health;
    bool running = false;
    public int ilosc_czasu_miedzy_obrazeniami;
    
    public int dmg;
    
    void OnTriggerEnter2D() {
        // Uruchomienie coroutine, która będzie wywoływać funkcję co 1 sekundę
        running = true;
        StartCoroutine(CallFunctionRepeatedly());
        health.health = health.health - dmg;
        
    }
    void OnTriggerExit2D() {
        running = false;
    }
    
    void Start()
    {
        dmg = 10;
        ilosc_czasu_miedzy_obrazeniami = 1000;
        
    }

    IEnumerator CallFunctionRepeatedly()
    {
        while (running)
        {
            yield return new WaitForSeconds(1f); // Oczekiwanie 1 sekundy
            ExecuteFunction(); // Wywołanie funkcji
        }
    }

    void ExecuteFunction()
    {
        // Funkcja będzie wywoływana co 1 sekundę
        health.health = health.health - dmg;
    }

    
    
    
    
}
