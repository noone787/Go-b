using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEditor;

public class NPC_system : MonoBehaviour
{
    [SerializeField] GameObject dialogBox;
    [SerializeField] TMP_Text dialogText;
    [SerializeField] GameObject dialogNext;
    bool player_detection = false;
    bool change_dialog = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  (PlayerMovement.PlayerDialogue && Input.GetKeyDown(KeyCode.Mouse0) && change_dialog)
                {
                    PlayerMovement.PlayerDialogue = false;
                    dialogBox.SetActive(false);
                }
        if (player_detection && !PlayerMovement.PlayerDialogue && Input.GetKeyDown(KeyCode.F))
        {
            change_dialog = false;
            StartCoroutine(dialog());
        }
    }


    IEnumerator dialog()
    {
        {
            if (player_detection) // && Input.GetKeyDown(KeyCode.F) && !PlayerMovement.PlayerDialogue)
            {
                Debug.Log("dialog");
                PlayerMovement.PlayerDialogue = true;
                dialogBox.SetActive(true);
                dialogNext.SetActive(false);
                dialogText.text = "kupka w dupce chlupce";
                yield return new WaitForSeconds(2);
                change_dialog = true;
                dialogNext.SetActive(true);
            }
        }
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            player_detection = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player_detection = false;
    }

}
