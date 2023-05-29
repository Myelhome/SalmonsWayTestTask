using UnityEngine;

public class PopupCloseButton : MonoBehaviour
{
    [SerializeField] Popup currentPopup;

    private UIBehavior uIBehavior;

    private void Start()
    {
        uIBehavior = FindAnyObjectByType<UIBehavior>();
    }

    public void CloseThis()
    {
        uIBehavior.HideDialogueWindow(currentPopup);
    }
}
