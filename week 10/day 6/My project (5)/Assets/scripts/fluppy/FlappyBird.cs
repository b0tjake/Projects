using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float tiltSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Jump logic
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }

        // Rotation logic (Bird looks up when rising, down when falling)
        float targetAngle = Mathf.Clamp(rb.linearVelocity.y * tiltSpeed, -90, 30);
        transform.rotation = Quaternion.Euler(0, 0, targetAngle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Restart game on hit
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}