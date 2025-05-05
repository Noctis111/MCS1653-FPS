using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void OnPlayButton ()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OnPGButton()
    {
        SceneManager.LoadScene("Playground");
    }

    public void OnExitButton ()
    {
        Application.Quit();
    }
}
