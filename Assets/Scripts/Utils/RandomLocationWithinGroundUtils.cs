using UnityEngine;

public class RandomLocationWithinGroundUtils : LocationUtils
{

    private Collider groundCollider;

    private void Start()
    {
        var ground = FindAnyObjectByType<Ground>();
        if (ground != null) groundCollider = ground.gameObject.GetComponent<Collider>();
    }

    public override Vector3 GetLocation()
    {
        if (groundCollider == null) return base.GetLocation();

        return GetRandomRectangleLocationWithinGround();
    }

    private Vector3 GetRandomRectangleLocationWithinGround()
    {
        var bounds = groundCollider.bounds;
        var topRight = bounds.max;
        var bottomLeft = bounds.min;

        return new Vector3(Random.Range(bottomLeft.x, topRight.x), topRight.y, Random.Range(bottomLeft.z, topRight.z));
    }
}
