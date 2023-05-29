using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private AmountUtils amountUtils;
    [SerializeField] private EntityUtils entityUtils;
    [SerializeField] private LocationUtils locationUtils;
    [SerializeField] private TargetUtils targetUtils;
    [SerializeField] private RotationUtils rotationUtils;

    private SettingsManager config;
    private EnemyManager enemyManager;

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
        enemyManager = FindAnyObjectByType<EnemyManager>();
    }

    public void SpawnEnemy()
    {

        for (int i = 0; i < amountUtils.GetAmount(); i++)
        {
            var enemy = Instantiate(entityUtils.GetEntity(), locationUtils.GetLocation(), rotationUtils.GetRotation(), config.EnemiesParent.transform);

            var targetable = enemy.GetComponent<ITargetable>();
            var enemySO = enemy.GetComponent<BaseEnemy>();
            if (targetable != null && enemySO != null) targetable.SetPersutedTarget(targetUtils.GetTarget(enemySO.EnemySO.Targets));

            enemyManager.IncreaseEnemyCounter(1);
        }
    }
}
