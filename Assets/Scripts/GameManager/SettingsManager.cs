using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private GameConfigSO buildSettings;
    [SerializeField] private EnemySpawnConfigSO enemySpawnSettings;
    [SerializeField] private ObstacleSpawnConfigSO obstacleSpawnSettings;
    [SerializeField] private PopupSpawnConfigSO popupSpawnSettings;
    [SerializeField] private GameObject enemiesParent;
    [SerializeField] private GameObject obstacleParent;
    [SerializeField] private GameObject popupParent;

    public GameConfigSO BuildSettings { get => buildSettings; set => buildSettings = value; }
    public EnemySpawnConfigSO EnemySpawnSettings { get => enemySpawnSettings; set => enemySpawnSettings = value; }
    public ObstacleSpawnConfigSO ObstacleSpawnSettings { get => obstacleSpawnSettings; set => obstacleSpawnSettings = value; }
    public PopupSpawnConfigSO PopupSpawnSettings { get => popupSpawnSettings; set => popupSpawnSettings = value; }
    public GameObject EnemiesParent { get => enemiesParent; set => enemiesParent = value; }
    public GameObject ObstacleParent { get => obstacleParent; set => obstacleParent = value; }
    public GameObject PopupParent { get => popupParent; set => popupParent = value; }
}
