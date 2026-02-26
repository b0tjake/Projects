using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int MaxHealth { get; private set; }
    private int currentHealth;

    public event Action OnDeath;

    public void Initialize(int maxHealth)
    {
        MaxHealth = maxHealth;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
    }

    public void ResetHealth()
    {
        currentHealth = MaxHealth;
    }
}