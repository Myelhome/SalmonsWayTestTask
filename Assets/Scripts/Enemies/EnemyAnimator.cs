using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] BaseEnemy enemy;

    private SettingsManager config;

    private Animator animator;

    private string isWalking;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        config = FindObjectOfType<SettingsManager>();
        isWalking = config.BuildSettings.EnemyIsWalkingAnimationKey;
    }

    private void Update()
    {
        animator.SetBool(isWalking, enemy.IsWalking());
    }
}
