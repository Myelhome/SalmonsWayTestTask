using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] private Text text;

    public void ChangeText(string text)
    {
        this.text.text = text;
    }

    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
