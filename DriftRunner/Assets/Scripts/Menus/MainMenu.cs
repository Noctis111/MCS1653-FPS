using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject controlCreditsPanel;

    void Start()
    {
        controlCreditsPanel.SetActive(false);  // Ensure panel is hidden on load
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene("L1");
    }

    public void OnPGButton()
    {
        SceneManager.LoadScene("Playground");
    }

    public void OnExitButton()
    {
        Application.Quit();
    }

    public void ShowControlCredits()
    {
        controlCreditsPanel.SetActive(true);
    }

    public void HideControlCredits()
    {
        controlCreditsPanel.SetActive(false);
    }
}

