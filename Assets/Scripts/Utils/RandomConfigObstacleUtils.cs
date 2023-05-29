using UnityEngine;

public class RandomConfigObstacleUtils : EntityUtils
{
    private SettingsManager config;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
    }

    public override Transform GetEntity()
    {
        var obstacles = config.ObstacleSpawnSettings.ObstaclesToSpawn;
        if (obstacles == null || obstacles.Length == 0) return base.GetEntity();

        return GetConfigRandomObstacle(obstacles);
    }

    private Transform GetConfigRandomObstacle(ObstacleSO[] obstacles)
    {
        return obstacles[Random.Range(0, obstacles.Length)].Prefab;
    }
}
