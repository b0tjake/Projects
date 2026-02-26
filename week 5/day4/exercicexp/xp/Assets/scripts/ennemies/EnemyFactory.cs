using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] ObjectPool pool;
    [SerializeField] EnemyDataSO enemyData;

    public void Spawn(Vector3 position)
    {
        GameObject obj = pool.Get();
        obj.transform.position = position;

        Enemy enemy = obj.GetComponent<Enemy>();
        enemy.Initialize(enemyData);
    }
}