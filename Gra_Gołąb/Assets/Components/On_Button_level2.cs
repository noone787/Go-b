using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class On_Button_level_2 : MonoBehaviour
{
    [SerializeField] private string level2 = "level2";

    public void NewGameButton() {
        SceneManager.LoadScene(level2);
    }
    
}

