using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CircleScript : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private bool isGrounded = false;
    private bool hasStartedMoving = false; // Tracks the first move

    public Rigidbody2D rb;
    public TextMeshProUGUI coinText; 
    private int coinCount = 0;
    private Animator anim; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * playerSpeed, rb.linearVelocity.y);

        bool isMoving = Mathf.Abs(horizontalInput) > 0.1f;

        // Check for the very first movement
        if (isMoving && !hasStartedMoving)
        {
            anim.SetTrigger("firstMove"); // Trigger the hands-up animation
            hasStartedMoving = true;
        }

        anim.SetBool("moving", isMoving);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // Sprite Flipping
        if (horizontalInput != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(horizontalInput), 1, 1);
        }
    }

    // THIS DETECTS THE COIN PICKUP
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
                coinCount++; // 3. Increase the number
                UpdateUI();  // 4. Update the screen            
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
        Debug.Log("Game Over!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}