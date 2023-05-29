using UnityEngine;

public class RandomConfigEnemyUtils : EntityUtils
{
    private SettingsManager config;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
    }

    public override Transform GetEntity()
    {
        var enemies = config.EnemySpawnSettings.EnemiesToSpawn;
        if (enemies == null || enemies.Length == 0) return base.GetEntity();

        return GetConfigRandomEnemy(enemies);
    }

    private Transform GetConfigRandomEnemy(EnemySO[] enemies)
    {
        return enemies[Random.Range(0, enemies.Length)].Prefab;
    }
}
