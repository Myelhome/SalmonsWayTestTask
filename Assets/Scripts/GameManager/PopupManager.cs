using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    private LinkedList<Popup> popups = new LinkedList<Popup>();

    public void UpdateText(string text)
    {
        foreach (var popup in popups) popup.ChangeText(text);
    }

    public void Add(Popup popup)
    {
        popups.AddLast(popup);
    }

    public void Delete(Popup popup)
    {
        popups.Remove(popup);
        popup.SelfDestroy();
    }

    public Transform GetLastPosition()
    {
        if (popups.Count == 0) return null;
        return popups.Last.Value.transform;
    }
}
