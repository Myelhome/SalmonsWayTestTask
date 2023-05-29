using UnityEngine;

public abstract class LocationUtils : MonoBehaviour
{
    public virtual Vector3 GetLocation()
    {
        return Vector3.zero;
    }
}
