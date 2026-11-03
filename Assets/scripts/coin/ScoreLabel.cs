using TMPro;
using UnityEngine;

public class ScoreLabel : MonoBehaviour
{
    [SerializeField] private TMP_Text label;
    private int score;

    void Start()
    {
        label.text = "Score: 0/9";
    }

    public void Add(int points)
    {
        score += points;
        label.text = $"Score: {score}/9";
    }
}