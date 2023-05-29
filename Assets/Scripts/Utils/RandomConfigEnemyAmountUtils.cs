using UnityEngine;

public class RandomConfigEnemyAmountUtils : AmountUtils
{
    private SettingsManager config;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
    }

    public override int GetAmount()
    {
        var min = config.EnemySpawnSettings.MinSpawnEnemiesAmount;
        var max = config.EnemySpawnSettings.MaxSpawnEnemiesAmount;

        if (max < min || min < 0) return base.GetAmount();

        return GetConfigMinMaxAmount(min, max);
    }

    private int GetConfigMinMaxAmount(int min, int max)
    {

        return Random.Range(min, max + 1);
    }
}
