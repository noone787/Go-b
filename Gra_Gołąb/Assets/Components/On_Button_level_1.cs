using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class On_Button_level_1 : MonoBehaviour
{
    [SerializeField] private string gra = "main";

    public void NewGameButton() {
        SceneManager.LoadScene(gra);
    }
    
}
