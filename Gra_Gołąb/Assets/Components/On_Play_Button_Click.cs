using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class On_Play_Button_Click : MonoBehaviour
{
    [SerializeField] private string gra = "Level_Menu";

    public void NewGameButton() 
    {
        SceneManager.LoadScene(gra);
    }
    
}
