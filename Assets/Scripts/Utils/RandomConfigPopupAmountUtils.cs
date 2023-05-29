using UnityEngine;

public class RandomConfigPopupAmountUtils : AmountUtils
{
    private SettingsManager config;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
    }

    public override int GetAmount()
    {
        var min = config.PopupSpawnSettings.MinSpawnPopupsAmount;
        var max = config.PopupSpawnSettings.MaxSpawnPopupsAmount;

        if (max < min || min < 0) return base.GetAmount();

        return GetConfigMinMaxAmount(min, max);
    }

    private int GetConfigMinMaxAmount(int min, int max)
    {

        return Random.Range(min, max + 1);
    }
}
