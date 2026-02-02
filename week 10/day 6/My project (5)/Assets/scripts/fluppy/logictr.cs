using UnityEngine;

public class logictr : MonoBehaviour
{
    private bool hasScored = false; // Prevents double scoring

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. Check if we already scored for this pipe
        // 2. Check if the object is the Player
        if (!hasScored && collision.gameObject.CompareTag("Player"))
        {
            hasScored = true; // Lock it so it can't trigger again
            ScoreManager.instance.AddScore();
        }
    }
}