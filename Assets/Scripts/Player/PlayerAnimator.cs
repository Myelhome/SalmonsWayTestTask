using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private SettingsManager config;

    [SerializeField] Player player;

    private Animator animator;

    private string isWalking;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        isWalking = config.BuildSettings.PlayerIsWalkingAnimationKey;
    }

    private void Update()
    {
        animator.SetBool(isWalking, player.IsWalking());
    }
}
