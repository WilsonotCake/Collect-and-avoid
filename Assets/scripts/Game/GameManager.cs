using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState { Playing, Lost }

    public GameState State { get; private set; } = GameState.Playing;

    public GameObject losePanel;

    void Awake()
    {
        Time.timeScale = 1f;
        losePanel.SetActive(false);
    }

    public void Lose()
    {
        if (State != GameState.Playing) return;

        State = GameState.Lost;
        losePanel.SetActive(true);
        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void TryAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}