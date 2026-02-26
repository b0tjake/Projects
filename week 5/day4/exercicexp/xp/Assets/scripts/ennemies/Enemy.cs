using UnityEngine;

[RequireComponent(typeof(HealthComponent))]
public class Enemy : MonoBehaviour
{
    EnemyDataSO data;
    HealthComponent health;

    public void Initialize(EnemyDataSO enemyData)
    {
        data = enemyData;
        health = GetComponent<HealthComponent>();
        health.Initialize(data.maxHealth);
        health.OnDeath += Die;
    }

    void Die()
    {
        EventBus.Instance.EnemyDied();
        gameObject.SetActive(false);
    }
}