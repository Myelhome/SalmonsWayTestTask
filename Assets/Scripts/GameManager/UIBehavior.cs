using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    private EnemyManager enemyManager;
    private PopupManager popupManager;
    private PopupSpawner popupSpawner;

    private EventSystem eventSystem;

    private void Start()
    {
        enemyManager = FindAnyObjectByType<EnemyManager>();
        popupManager = FindAnyObjectByType<PopupManager>();
        popupSpawner = FindAnyObjectByType<PopupSpawner>();

        eventSystem = EventSystem.current;
    }

    public void ShowDialogueWindow()
    {
        popupSpawner.SpawnPopup();
    }

    public void HideDialogueWindow(Popup popup)
    {
        eventSystem.SetSelectedGameObject(null);
        popupManager.Delete(popup);
    }

    public void UpdateEnemiesAmountText(int amount)
    {
        popupManager.UpdateText(amount.ToString());
    }

    public void DeleteAllEnemies()
    {
        eventSystem.SetSelectedGameObject(null);
        enemyManager.RemoveAllEnemies();
    }
}
