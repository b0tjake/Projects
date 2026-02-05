using UnityEngine;
using TMPro;


public class playerMovement : MonoBehaviour

{
private Rigidbody rb;

public float health = 100f;
public UnityEngine.UI.Slider healthSlider;
public float jumpForce = 5f;
private bool isGrounded = true;
public TMP_Text score;
private int scoreValue = 0;

public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);


        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

public void TakeDamage(float amount)
{
    health -= amount;
    health = Mathf.Clamp(health, 0, 100);
    healthSlider.value = health;

    if (health <= 0)
    {
        Die();
    }
}

public void Heal(float amount)
{
    health += amount;
    health = Mathf.Clamp(health, 0, 100);
    healthSlider.value = health;
}

void Die()
{
    UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
}

private void OnTriggerEnter(Collider other)
{
    if(other.gameObject.CompareTag("PickUp"))
    {
        other.gameObject.SetActive(false);
        scoreValue += 1;
        score.text = "Score: " + scoreValue.ToString();
    }
    if(other.gameObject.CompareTag("Heal"))
{
    other.gameObject.SetActive(false);
    Heal(25f); 
}
}
private void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
    }
}
}