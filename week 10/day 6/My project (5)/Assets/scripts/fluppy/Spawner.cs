using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1.5f;
    public float heightRange = 2f;
    private float timer;

    void Update()
    {
        if (timer > spawnRate)
        {
            float randomY = Random.Range(-heightRange, heightRange);
            Instantiate(pipePrefab, new Vector3(transform.position.x, randomY, 0), Quaternion.identity);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}