using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum GameState { MainMenu, Playing, Paused, GameOver }
    public GameState currentState = GameState.MainMenu;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        currentState = GameState.Playing;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Game Started!");
    }

    public void PauseGame()
    {
        currentState = GameState.Paused;
        Time.timeScale = 0f;
        Debug.Log("Game Paused");
    }

    public void ResumeGame()
    {
        currentState = GameState.Playing;
        Time.timeScale = 1f;
        Debug.Log("Game Resumed");
    }

    public void GameOver()
    {
        currentState = GameState.GameOver;
        Debug.Log("Game Over!");
        // TODO: Show game over UI, save score, etc.
    }
}