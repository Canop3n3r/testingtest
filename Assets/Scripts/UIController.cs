using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject mainMenuPanel;
    public GameObject gameHUD;
    public GameObject pauseMenu;
    public Text scoreText;

    private int score = 0;

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        gameHUD.SetActive(false);
        pauseMenu.SetActive(false);
    }

    public void StartGameButton()
    {
        GameManager.Instance.StartGame();
        ShowHUD();
    }

    public void ShowHUD()
    {
        mainMenuPanel.SetActive(false);
        gameHUD.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void UpdateScore(int points)
    {
        score += points;
        if (scoreText != null) scoreText.text = "Score: " + score;
    }

    public void PauseButton()
    {
        GameManager.Instance.PauseGame();
        pauseMenu.SetActive(true);
    }

    public void ResumeButton()
    {
        GameManager.Instance.ResumeGame();
        pauseMenu.SetActive(false);
    }
}