using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private AmountUtils amountUtils;
    [SerializeField] private EntityUtils entityUtils;
    [SerializeField] private LocationUtils locationUtils;
    [SerializeField] private RotationUtils rotationUtils;

    private SettingsManager config;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
    }

    public void SpawnObstacle()
    {
        var amount = amountUtils.GetAmount();

        for (int i = 0; i < amount; i++)
        {
            Instantiate(entityUtils.GetEntity(), locationUtils.GetLocation(), rotationUtils.GetRotation(), config.ObstacleParent.transform);
        }
    }
}
