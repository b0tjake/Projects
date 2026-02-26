using UnityEngine;

[CreateAssetMenu(menuName = "GameData/Enemy")]
public class EnemyDataSO : ScriptableObject
{
    public int maxHealth;
    public float moveSpeed;
    public int damage;
}