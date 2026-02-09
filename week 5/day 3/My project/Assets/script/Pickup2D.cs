using UnityEngine;

public class Pickup2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Energy Collected!");
            Destroy(gameObject);
        }
    }
}
