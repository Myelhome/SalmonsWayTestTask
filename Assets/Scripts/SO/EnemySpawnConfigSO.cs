using UnityEngine;

[CreateAssetMenu(menuName = "EnemySpawnConfigSO")]
public class EnemySpawnConfigSO : ScriptableObject
{
    [SerializeField] private int minSpawnEnemiesAmount;
    [SerializeField] private int maxSpawnEnemiesAmount;
    [SerializeField] private EnemySO[] enemiesToSpawn;

    public int MinSpawnEnemiesAmount { get => minSpawnEnemiesAmount; set => minSpawnEnemiesAmount = value; }
    public int MaxSpawnEnemiesAmount { get => maxSpawnEnemiesAmount; set => maxSpawnEnemiesAmount = value; }
    public EnemySO[] EnemiesToSpawn { get => enemiesToSpawn; set => enemiesToSpawn = value; }
}
