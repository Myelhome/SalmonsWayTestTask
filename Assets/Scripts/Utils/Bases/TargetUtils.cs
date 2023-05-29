using UnityEngine;

public abstract class TargetUtils : MonoBehaviour
{
    public virtual Transform GetTarget(Transform[] targets)
    {
        if (targets != null && targets.Length > 0) return targets[Random.Range(0, targets.Length)];

        return null;
    }
}
