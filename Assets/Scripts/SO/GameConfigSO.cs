using UnityEngine;

[CreateAssetMenu(menuName = "GameConfigSO")]
public class GameConfigSO : ScriptableObject
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerRotationSpeed;
    [SerializeField] private float playerGroundDrag;

    [SerializeField] private int enemyAmountBeforeNotify;

    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private string playerIsWalkingAnimationKey;
    [SerializeField] private string enemyIsWalkingAnimationKey;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }
    public float PlayerRotationSpeed { get => playerRotationSpeed; set => playerRotationSpeed = value; }
    public float PlayerGroundDrag { get => playerGroundDrag; set => playerGroundDrag = value; }
    public int EnemyAmountBeforeNotify { get => enemyAmountBeforeNotify; set => enemyAmountBeforeNotify = value; }
    public LayerMask GroundLayer { get => groundLayer; set => groundLayer = value; }
    public string PlayerIsWalkingAnimationKey { get => playerIsWalkingAnimationKey; set => playerIsWalkingAnimationKey = value; }
    public string EnemyIsWalkingAnimationKey { get => enemyIsWalkingAnimationKey; set => enemyIsWalkingAnimationKey = value; }
}
