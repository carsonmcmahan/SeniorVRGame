using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject playPanel;
    [SerializeField] private GameObject settingsPanel;


    public void MenuToPlay()
    {
        menuPanel.SetActive(false);
        playPanel.SetActive(true);     
    }

    public void PlayToMenu()
    {
        menuPanel.SetActive(true);
        playPanel.SetActive(false);
    }

    public void PlayToSettings()
    {
        menuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void SettingsToMenu()
    {
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void LoadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
