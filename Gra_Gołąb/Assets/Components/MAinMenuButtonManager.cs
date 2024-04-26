using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAinMenuButtonManager : MonoBehaviour
{
    [SerializeField] private string gra = "LevelMenu";
    [SerializeField] private string  options = "Options";

    public void PlayButton() 
    {
        SceneManager.LoadScene(gra);
    }
    public void OptionsButton() 
    {
        SceneManager.LoadScene(options);
    }

    public void QuitButton() 
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
