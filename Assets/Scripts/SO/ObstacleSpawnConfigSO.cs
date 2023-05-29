using UnityEngine;

[CreateAssetMenu(menuName = "ObstacleSpawnConfigSO")]
public class ObstacleSpawnConfigSO : ScriptableObject
{
    [SerializeField] private int minSpawnObstaclesAmount;
    [SerializeField] private int maxSpawnObstaclesAmount;
    [SerializeField] private ObstacleSO[] obstaclesToSpawn;

    public int MinSpawnObstaclesAmount { get => minSpawnObstaclesAmount; set => minSpawnObstaclesAmount = value; }
    public int MaxSpawnObstaclesAmount { get => maxSpawnObstaclesAmount; set => maxSpawnObstaclesAmount = value; }
    public ObstacleSO[] ObstaclesToSpawn { get => obstaclesToSpawn; set => obstaclesToSpawn = value; }
}
