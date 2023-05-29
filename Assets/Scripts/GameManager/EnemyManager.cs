using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private SettingsManager config;
    private UIBehavior behaviorUI;

    private int enemiesCount = 0;

    public int GetEnemiesAmount()
    {
        return enemiesCount;
    }

    public void SetEnemiesCount(int amount)
    {
        enemiesCount = amount;
        behaviorUI.UpdateEnemiesAmountText(enemiesCount);
    }

    private void Start()
    {
        config = FindAnyObjectByType<SettingsManager>();
        behaviorUI = FindAnyObjectByType<UIBehavior>();
    }

    public int GetEnemiesTotal()
    {
        return enemiesCount;
    }

    public void IncreaseEnemyCounter(int amount)
    {
        int oldAmount = enemiesCount;

        SetEnemiesCount(oldAmount + amount);

        if (oldAmount / config.BuildSettings.EnemyAmountBeforeNotify < enemiesCount / config.BuildSettings.EnemyAmountBeforeNotify) behaviorUI.ShowDialogueWindow();
    }


    //could have use enemiesParrent, but prefer to leave as is, due to changeability of enemiesParrent
    public void RemoveAllEnemies()
    {
        foreach (var enemy in FindObjectsOfType<BaseEnemy>()) enemy.SelfDestroy();
        SetEnemiesCount(0);
    }
}
