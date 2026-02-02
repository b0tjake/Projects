using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CircleScript : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private bool isGrounded = false;
    private bool hasStartedMoving = false;
    private bool hasWon = false; 
    private bool isControlEnabled = true;

    [Header("Win Menu Setup")]
public GameObject winMenu;

    [Header("Respawn Settings")]
    private Vector2 startPosition; // Stores the initial spawn point

    [Header("Audio Settings")]
    public AudioSource audioSource;
    public AudioClip winSound;

    public Rigidbody2D rb;
    public TextMeshProUGUI coinText; 
    private int coinCount = 0;
    private Animator anim; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        // Save the position where the penguin starts the level
        startPosition = transform.position; 
    }

    void Update()
    {
        if (!isControlEnabled) return;

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * playerSpeed, rb.linearVelocity.y);

        bool isMoving = Mathf.Abs(horizontalInput) > 0.1f;

        if (isMoving && !hasStartedMoving)
        {
            anim.SetTrigger("firstMove");
            hasStartedMoving = true;
        }

        anim.SetBool("moving", isMoving);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (horizontalInput != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(horizontalInput), 1, 1);
        }

        CheckWinCondition();
    }

    void CheckWinCondition()
    {
        if (!hasWon && transform.position.x >= 126.41f && transform.position.y >= 13.5f && coinCount == 7)
        {
            WinGame();
        }
    }

void WinGame()
{
    if (hasWon) return; 

    hasWon = true;
    isControlEnabled = false; 
    rb.linearVelocity = Vector2.zero; 
    
    if (audioSource != null && winSound != null)
    {
        audioSource.PlayOneShot(winSound);
    }

    // Start the animation
    anim.SetTrigger("win"); 
    Debug.Log("You Win! Waiting for animation...");

    // Start the delay timer
    StartCoroutine(WaitAndShowMenu());
}
private System.Collections.IEnumerator WaitAndShowMenu()
{
    // Wait for the duration you set (2 seconds)
    yield return new WaitForSeconds(2f);

    // Now show the menu and pause the game
    if (winMenu != null)
    {
        winMenu.SetActive(true);
        Time.timeScale = 0f; 
    }
}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            UpdateUI();            
            Destroy(other.gameObject); 
        }
        if (other.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    void UpdateUI()
    {
        coinText.text = "Coins: " + coinCount;
    }

    public void Die()
    {
        Debug.Log("Respawning...");
        
        // 1. Move the player back to the start
        transform.position = startPosition;
        
        // 2. Stop any falling/moving momentum
        rb.linearVelocity = Vector2.zero;

        // 3. OPTIONAL: Reset progress
        
        // Note: If you want coins to reappear, you would need a more 
        // complex system to "respawn" the destroyed coin objects.
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground")) isGrounded = true;
    }

    public void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground")) isGrounded = false;
    }
}