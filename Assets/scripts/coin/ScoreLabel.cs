using TMPro;
using UnityEngine;

public class ScoreLabel : MonoBehaviour
{
    [SerializeField] private TMP_Text label;
    private int score;

    public void Add(int points)
    {
        score += points;
        label.text = $"Score: {score}";
    }
}