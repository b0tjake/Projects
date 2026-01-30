using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;
    private Vector2 startPos;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = rb.position;
    }

    void FixedUpdate() // Use FixedUpdate for physics movement!
    {
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * distance;
        rb.MovePosition(new Vector2(startPos.x, newY));
    }
}