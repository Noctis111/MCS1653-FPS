using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverScreen;

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("Game Over!");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;  // Lock the cursor after restart
        Cursor.visible = false;  // Hide the cursor after restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;  // Lock the cursor when going to main menu
        Cursor.visible = false;  // Hide the cursor in the main menu
        SceneManager.LoadScene("StartMenu");
    }

    public void OnExitButton()
    {
        Application.Quit();
    }
}
