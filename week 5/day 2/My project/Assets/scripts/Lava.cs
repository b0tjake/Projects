using UnityEngine;

public class Lava : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
private void OnTriggerStay(Collider other)
{
    if (other.CompareTag("Player"))
    {
        // Notice: Use Time.deltaTime to damage slowly over time
        other.GetComponent<playerMovement>().TakeDamage(20f * Time.deltaTime);
    }
}
}
