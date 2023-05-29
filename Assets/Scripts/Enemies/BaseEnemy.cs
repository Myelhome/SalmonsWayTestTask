using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField] protected EnemySO enemySO;

    public EnemySO EnemySO { get => enemySO; set => enemySO = value; }

    public abstract bool IsWalking();

    public abstract void SelfDestroy();
}
