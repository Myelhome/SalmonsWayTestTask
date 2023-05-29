using UnityEngine;

public class PopupSpawner : MonoBehaviour
{
    [SerializeField] private AmountUtils amountUtils;
    [SerializeField] private EntityUtils entityUtils;
    [SerializeField] private LocationUtils locationUtils;
    [SerializeField] private RotationUtils rotationUtils;

    private SettingsManager config;
    private PopupManager popupManager;
    private EnemyManager enemyManager;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
        popupManager = FindAnyObjectByType<PopupManager>();
        enemyManager = FindAnyObjectByType<EnemyManager>();
    }

    public void SpawnPopup()
    {

        for (int i = 0; i < amountUtils.GetAmount(); i++)
        {
            var popupGameObject = Instantiate(entityUtils.GetEntity(), locationUtils.GetLocation(), rotationUtils.GetRotation(), config.PopupParent.transform);

            var popup = popupGameObject.GetComponent<Popup>();
            if (popup != null)
            {
                popup.ChangeText(enemyManager.GetEnemiesAmount().ToString());
                popupManager.Add(popup);
            }
        }
    }
}