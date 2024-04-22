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
    bool player_detection = false;
    void Start()
    {
        StartCoroutine(dialog());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator dialog()
    {
        if (player_detection && Input.GetKeyDown(KeyCode.F) && !PlayerMovement.PlayerDialogue)
        {
            Debug.Log("dialog");
            PlayerMovement.PlayerDialogue = true;
            dialogBox.SetActive(true);
            dialogText.text = "kupka w dupce chlupce";
            yield return new WaitForSeconds(2);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                PlayerMovement.PlayerDialogue = false;
                dialogBox.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("pressed esc");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("pressed f");
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
