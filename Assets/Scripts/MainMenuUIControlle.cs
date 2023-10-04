using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class MainMenuUIControlle : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitButton);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void ExitButton()
    {
        Application.Quit();
    }
}
