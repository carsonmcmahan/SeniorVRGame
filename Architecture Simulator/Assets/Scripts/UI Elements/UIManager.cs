using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UI Panels")]
    [SerializeField] private GameObject titlePanel;
    [SerializeField] private GameObject modelsPanel;

    [Header("Model Buttons")]
    [SerializeField] private GameObject houseOneButtons;
    [SerializeField] private GameObject houseTwoButtons;

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
