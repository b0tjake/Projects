using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Movement Settings")]
    public float distance = 5f; 
    public float speed = 2f;  
    public bool moveHorizontal = true;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {

        float movement = Mathf.Sin(Time.time * speed) * distance;

        if (moveHorizontal)
        {
            transform.position = startPos + new Vector3(movement, 0, 0);
        }
        else
        {
            transform.position = startPos + new Vector3(0, 0, movement);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}