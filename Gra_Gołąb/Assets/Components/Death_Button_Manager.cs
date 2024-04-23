using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death_Button_Manager : MonoBehaviour
{
    [SerializeField] private string menu = "LevelMenu";
    [SerializeField] private string gra = "main";
    public void RetryButton() 
    {
        SceneManager.LoadScene(gra);
    }
    public void MenuButton() 
    {
        SceneManager.LoadScene(menu);
    }
}
