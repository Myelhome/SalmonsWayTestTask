using UnityEngine;

public class RandomConfigPopupUtils : EntityUtils
{
    private SettingsManager config;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
    }

    public override Transform GetEntity()
    {
        var popups = config.PopupSpawnSettings.PopupsToSpawn;
        if (popups == null || popups.Length == 0) return base.GetEntity();

        return GetConfigRandomEnemy(popups);
    }

    private Transform GetConfigRandomEnemy(GameObject[] popups)
    {
        return popups[Random.Range(0, popups.Length)].transform;
    }
}
