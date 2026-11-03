using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource coinSource;
    [SerializeField] private AudioClip coinClip;
    [SerializeField] private ScoreLabel scoreLabel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinSource.PlayOneShot(coinClip);
            scoreLabel.Add(1);
            Destroy(gameObject);
        }
    }
}