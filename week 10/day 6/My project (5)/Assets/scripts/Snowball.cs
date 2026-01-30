using UnityEngine;

public class Snowball : MonoBehaviour
{
    public float speed = 8f;
    
    public float lifeSpan = 0.3f; 

    void Start()
    {
        // Deletes the snowball after 4 seconds so it doesn't fly forever
        Destroy(gameObject, lifeSpan);
    }

    void Update()
    {
        // Moves the snowball linearly to the left
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the thing we hit is the Player
        if (other.CompareTag("Player"))
        {
            // Find the CircleScript on the player and call the Die function
            CircleScript player = other.GetComponent<CircleScript>();
            
            if (player != null)
            {
                player.Invoke("Die", 0); 
            }

            Destroy(gameObject); // Destroy the snowball after it hits
        }
    }
}