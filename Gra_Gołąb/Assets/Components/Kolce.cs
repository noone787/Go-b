using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class Kolce : MonoBehaviour
{
    public Health health;
    public Health health_inventory;
    bool running = false;
    bool napewno = false;
    public int ilosc_czasu_miedzy_obrazeniami;
    
    public int dmg;

    // Sound Effects
    public AudioSource audioSource;
    public AudioClip sfx2;
    
    void OnTriggerEnter2D() {
        napewno = true;
        running = true;
        health.health = health.health - dmg;
        health_inventory.health = health_inventory.health - dmg;
        StartCoroutine(CallFunctionRepeatedly());
        audioSource.Play();
        
        
    }
    void OnTriggerExit2D() {
        running = false;
        napewno = false;
    }
    
    void Start()
    {
        dmg = 10;
        ilosc_czasu_miedzy_obrazeniami = 1000;
        audioSource.clip = sfx2;
        
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
        if (napewno == true) {
        health.health = health.health - dmg;
        health_inventory.health = health_inventory.health - dmg;
        audioSource.Play();
        }
    }

    
    
    
    
}
