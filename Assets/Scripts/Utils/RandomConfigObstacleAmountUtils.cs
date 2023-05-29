using UnityEngine;

public class RandomConfigObstacleAmountUtils : AmountUtils
{
    private SettingsManager config;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
    }

    public override int GetAmount()
    {
        var min = config.ObstacleSpawnSettings.MinSpawnObstaclesAmount;
        var max = config.ObstacleSpawnSettings.MaxSpawnObstaclesAmount;

        if (max < min || min < 0) return base.GetAmount();

        return GetConfigMinMaxAmount(min, max);
    }

    private int GetConfigMinMaxAmount(int min, int max)
    {

        return Random.Range(min, max + 1);
    }
}
