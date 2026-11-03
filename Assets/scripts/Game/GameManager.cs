using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState { Playing, Lost }

    public GameState State { get; private set; } = GameState.Playing;

    public void Lose()
    {
        if (State != GameState.Playing) return;

        State = GameState.Lost;
        Debug.Log("You lose!");
    }
}