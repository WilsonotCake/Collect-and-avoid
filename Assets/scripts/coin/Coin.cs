using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private ScoreLabel scoreLabel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin collected");
            scoreLabel.Add(1);
            Destroy(gameObject);
        }
    }
}