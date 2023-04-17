using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject titlePanel;
    public GameObject modelsPanel;

    [Header("Model Buttons")]
    public GameObject houseOneButtons;
    public GameObject houseTwoButtons;

    public void TitleToModels()
    {

        titlePanel.SetActive(false);
        modelsPanel.SetActive(true);
    }

    public void BackButton()
    {
        modelsPanel.SetActive(false);
        titlePanel.SetActive(true);
    }

    public void HouseOneButtons()
    {
        houseOneButtons.SetActive(true);
        houseTwoButtons.SetActive(false);
    }

    public void HouseTwoModels()
    {
        houseOneButtons.SetActive(false);
        houseTwoButtons.SetActive(true);
    }
}
