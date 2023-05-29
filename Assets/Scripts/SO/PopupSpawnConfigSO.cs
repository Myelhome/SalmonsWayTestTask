using UnityEngine;

[CreateAssetMenu(menuName = "PopupSpawnConfigSO")]
public class PopupSpawnConfigSO : ScriptableObject
{
    [SerializeField] private int minSpawnPopupsAmount;
    [SerializeField] private int maxSpawnPopupsAmount;
    [SerializeField] private GameObject[] popupsToSpawn;
    [SerializeField] private Vector3 offset;

    public int MinSpawnPopupsAmount { get => minSpawnPopupsAmount; set => minSpawnPopupsAmount = value; }
    public int MaxSpawnPopupsAmount { get => maxSpawnPopupsAmount; set => maxSpawnPopupsAmount = value; }
    public GameObject[] PopupsToSpawn { get => popupsToSpawn; set => popupsToSpawn = value; }
    public Vector3 Offset { get => offset; set => offset = value; }
}
