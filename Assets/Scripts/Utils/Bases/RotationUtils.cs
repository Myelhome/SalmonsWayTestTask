using UnityEngine;

public abstract class RotationUtils : MonoBehaviour
{
    public virtual Quaternion GetRotation()
    {
        return new Quaternion(0, 0, 0, 0);
    }
}
