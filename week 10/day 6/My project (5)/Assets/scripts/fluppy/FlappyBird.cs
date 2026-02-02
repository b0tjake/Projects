using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float tiltSpeed = 5f;

    [Header("Audio")]
    [SerializeField] private AudioClip[] tapSounds; 

    private Rigidbody2D rb;
    private AudioSource audioSource;
    private bool isDead = false; // Prevents the menu from opening multiple times

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.playOnAwake = false;
        audioSource.loop = false;
        audioSource.spatialBlend = 0f; 
        audioSource.volume = 0.7f;
    }

    void Update()
    {
        if (isDead) return; // Stop input if dead

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        float targetAngle = Mathf.Clamp(rb.linearVelocity.y * tiltSpeed, -90f, 30f);
        transform.rotation = Quaternion.Euler(0, 0, targetAngle);
    }

    void Jump()
    {
        rb.linearVelocity = Vector2.up * jumpForce;
        PlayRandomTapSound();
    }

    void PlayRandomTapSound()
    {
        if (tapSounds == null || tapSounds.Length == 0) return;
        int randomIndex = Random.Range(0, tapSounds.Length);
        audioSource.pitch = Random.Range(0.95f, 1.05f);
        audioSource.PlayOneShot(tapSounds[randomIndex]);
    }

    // FIX: Changed Collider2D to Collision2D for physics hits
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;
        
        isDead = true;
        
        // Safety check for ScoreManager
        int currentScore = 0;
        if (ScoreManager.instance != null)
        {
            currentScore = int.Parse(ScoreManager.instance.scoreText.text);
        }

        // Show the Menu
        GameOverManager manager = FindObjectOfType<GameOverManager>();
        if (manager != null)
        {
            manager.ShowGameOver(currentScore);
        }
        else
        {
            // If you forgot to add the manager, just restart so the game doesn't hang
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}