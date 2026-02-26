using System;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    public static EventBus Instance { get; private set; }

    public event Action OnEnemyDeath;
    public event Action OnPlayerDamaged;
    public event Action<int> OnScoreChanged;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void EnemyDied() => OnEnemyDeath?.Invoke();
    public void PlayerDamaged() => OnPlayerDamaged?.Invoke();
    public void ScoreChanged(int score) => OnScoreChanged?.Invoke(score);
}