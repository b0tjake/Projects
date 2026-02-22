using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float speed = 5f;
    public float jumpForce = 10f;
    public bool isGrounded;
    private int collectibles = 0;
    public TMPro.TextMeshProUGUI collectiblesText;
    public int maxHealth = 100;
    private int currentHealth;

    public Slider healthBar;

    public int damage = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        healthBar.maxValue = maxHealth;
        currentHealth = maxHealth;
        UpdateUI();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized;
    rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y, movement.z * speed); 
        // jump

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if(collision.gameObject.CompareTag("coin"))
        {
            Debug.Log("Coin collected");
            Destroy(collision.gameObject);
            collectibles++;
            UpdateUI();
        }
        
    }
    void OnCollisionStay(Collision collision)
    {
         if (collision.gameObject.CompareTag("lava"))
        {
            takeDamage(damage);
            
        }
    }

    void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
        void UpdateUI()
        {
            collectiblesText.text = "coins: " + collectibles;
        }
}
