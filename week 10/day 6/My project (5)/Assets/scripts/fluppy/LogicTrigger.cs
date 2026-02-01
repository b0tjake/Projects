using UnityEngine;

public class LogicTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object entering the gap is the player
        // Ensure your penguin has the Tag "Player" in the Inspector!
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore();
        }
    }
}