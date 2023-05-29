using UnityEngine;

[CreateAssetMenu(menuName = "EnemySO")]
public class EnemySO : ScriptableObject
{
    [SerializeField] private string objectName;
    [SerializeField] private Transform prefab;
    [SerializeField] private float speed;
    [SerializeField] private float angularRotationSpeed;
    [SerializeField] private Transform[] targets;
    [SerializeField] private float idleMaxMagnitude;

    [SerializeField] private float agentStoppingDistance;

    public string ObjectName { get => objectName; set => objectName = value; }
    public Transform Prefab { get => prefab; set => prefab = value; }
    public float Speed { get => speed; set => speed = value; }
    public float AngularRotationSpeed { get => angularRotationSpeed; set => angularRotationSpeed = value; }
    public Transform[] Targets { get => targets; set => targets = value; }
    public float IdleMaxMagnitude { get => idleMaxMagnitude; set => idleMaxMagnitude = value; }
    public float AgentStoppingDistance { get => agentStoppingDistance; set => agentStoppingDistance = value; }
}
