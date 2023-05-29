using UnityEngine;

[CreateAssetMenu(menuName = "ObstacleSO")]
public class ObstacleSO : ScriptableObject
{
    [SerializeField] private string objectName;
    [SerializeField] private Transform prefab;

    public string ObjectName { get => objectName; set => objectName = value; }
    public Transform Prefab { get => prefab; set => prefab = value; }
}
