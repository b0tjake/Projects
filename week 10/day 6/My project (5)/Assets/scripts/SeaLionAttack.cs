using UnityEngine;

public class SeaLionSpawner : MonoBehaviour
{
    public GameObject snowballPrefab;
    public Transform throwPoint;

    // The Animation Event calls this function
    public void LaunchSnowball()
    {
        Instantiate(snowballPrefab, throwPoint.position, Quaternion.identity);
    }
}