using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUIControlle : MonoBehaviour
{
    public GameObject menu;
    public GameObject credit;
    public Button playButton;
    public Button creditButton;
    public Button returnButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        creditButton.onClick.AddListener(CreditButton);
        exitButton.onClick.AddListener(ExitButton);
        returnButton.onClick.AddListener(ReturnButton);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void ExitButton()
    {
        Application.Quit();
    }

    private void CreditButton()
    {
        menu.SetActive(false);
        credit.SetActive(true);
    }

    private void ReturnButton()
    {
        menu.SetActive(true);
        credit.SetActive(false);
    }
}
