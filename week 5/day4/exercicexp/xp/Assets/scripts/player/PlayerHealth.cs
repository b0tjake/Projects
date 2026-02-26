using UnityEngine;

[RequireComponent(typeof(HealthComponent))]
public class PlayerHealth : MonoBehaviour
{
    HealthComponent health;

    void Awake()
    {
        health = GetComponent<HealthComponent>();
        health.Initialize(100);
        health.OnDeath += OnDeath;
    }

    void OnDeath()
    {
        EventBus.Instance.PlayerDamaged();
    }
}