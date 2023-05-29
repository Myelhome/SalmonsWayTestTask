using UnityEngine;

public class RandomRotationUtils : RotationUtils
{
    public override Quaternion GetRotation()
    {
        return GetRandomRotation();
    }

    private Quaternion GetRandomRotation()
    {
        var randomRotation = Random.rotation;
        randomRotation.x = 0;
        randomRotation.z = 0;
        return randomRotation;
    }
}
