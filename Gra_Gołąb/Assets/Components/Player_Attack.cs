using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UIElements;

public class Player_Attack : MonoBehaviour
{
    public float distance = 5f;  // Dystans, o który ma przesunąć się kula
    public float speed = 2f;     // Prędkość ruchu
    public GameObject game;
    public PlayerMovement playerMovement;
    public Transform transform_gracza;
    public Sprite sprite2;
    private Vector3 startPosition;
    
    
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.R)) {
            GameObject atak = new GameObject("Kula");
            
            atak.transform.position = game.transform.position;
            atak.transform.localScale += new UnityEngine.Vector3(0.5f, 0.5f, 0.5f);
            SpriteRenderer spriteRenderer = atak.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite2;

            // jak gracz w lewo

            if (playerMovement.Potrzebne_Do_Ataku == false) {
                atak.transform.position += new UnityEngine.Vector3(-3,0,0);
                startPosition = atak.transform.position;
                
            }

            // jak gracz w prawo

            else if (playerMovement.Potrzebne_Do_Ataku == true) {
                atak.transform.position += new UnityEngine.Vector3(3,0,0);
                startPosition = atak.transform.position;
                
                

            }
        }
    }
}
