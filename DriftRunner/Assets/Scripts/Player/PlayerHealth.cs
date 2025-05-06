using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    private bool isGameOver = false;

    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject gameOverPanel;

    public PostProcessVolume postProcessVolume;
    private Vignette vignette;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHeartUI();
        gameOverPanel.SetActive(false);

        if (postProcessVolume != null)
        {
            postProcessVolume.profile.TryGetSettings(out vignette);
            vignette.intensity.value = 0f; // start invisible
        }
    }

    void Update()
    {
        if (transform.position.y < -20)
        {
            Debug.Log("Player died!");
            GameOver();
        }
    }

    public void LoseHealth(int damage)
    {
        if (isGameOver) return;

        currentHealth -= damage;
        Debug.Log("Player took " + damage + " damage. Current health: " + currentHealth);
        UpdateHeartUI();
        StartCoroutine(DamageFlash());

        if (currentHealth <= 0)
        {
            Debug.Log("Player died!");
            GameOver();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            LoseHealth(1);
        }
    }

    void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("Game Over!");
    }

    void UpdateHeartUI()
    {
        if (currentHealth > numOfHearts)
        {
            currentHealth = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            hearts[i].enabled = i < numOfHearts;
        }
    }

    IEnumerator DamageFlash()
    {
        if (vignette == null) yield break;

        float elapsed = 0f;
        float duration = 0.5f;
        float maxIntensity = 0.5f;

        // Fade in
        while (elapsed < duration / 2)
        {
            vignette.intensity.value = Mathf.Lerp(0f, maxIntensity, elapsed / (duration / 2));
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Fade out
        elapsed = 0f;
        while (elapsed < duration / 2)
        {
            vignette.intensity.value = Mathf.Lerp(maxIntensity, 0f, elapsed / (duration / 2));
            elapsed += Time.deltaTime;
            yield return null;
        }

        vignette.intensity.value = 0f;
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}