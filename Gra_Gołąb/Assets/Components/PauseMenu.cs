using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public string menuScene = "LevelMenu";
    

    void Update()
    {
        Debug.Log("pause update");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("pauza");
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
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

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("resume");
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("pause");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(menuScene);
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
