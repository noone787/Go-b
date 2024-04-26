using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsButtonManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    [SerializeField] private string mainmenu = "MainMenu";

    public Dropdown resolutionDropdown;
    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions; 
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        for (int i = 0; i <resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
        }
        resolutionDropdown.AddOptions(options);
    }

    public void BackToMain() 
    {
        SceneManager.LoadScene(mainmenu);
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetSfxVolume(float volume)
    {

    }

    public void ToggleFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
