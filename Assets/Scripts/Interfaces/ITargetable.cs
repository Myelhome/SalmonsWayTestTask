using UnityEngine;

public interface ITargetable
{
    public Transform GetPersutedTarget();
    public void SetPersutedTarget(Transform persutedTarget);
}
