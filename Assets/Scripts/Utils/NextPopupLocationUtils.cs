using UnityEngine;

public class NextPopupLocationUtils : LocationUtils
{
    private SettingsManager config;
    private PopupManager popupManager;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
        popupManager = FindAnyObjectByType<PopupManager>();
    }

    public override Vector3 GetLocation()
    {
        var lastTransform = popupManager.GetLastPosition();
        
        if (lastTransform == null) return config.PopupParent.transform.position;
        
        return lastTransform.position + config.PopupSpawnSettings.Offset;
    }
}
