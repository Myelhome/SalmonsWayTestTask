using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

public class SparrowEnemy : BaseEnemy, ITargetable
{
    private Transform persutedTarget;
    private NavMeshAgent agent;

    private bool ableToMove = false;

    private float zeroMagnitude;

    public Transform GetPersutedTarget()
    {
        return persutedTarget;
    }

    public void SetPersutedTarget(Transform value)
    {
        persutedTarget = value;
    }

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {

        AsyncStart();
    }

    private async void AsyncStart()
    {
        await AwaitBerforePersuit();
        ableToMove = true;
    }

    private async Task AwaitBerforePersuit()
    {
        await Task.Delay(1500);
    }

    private void Update()
    {
        UpdateParams();
        Persuit();
    }

    private void UpdateParams()
    {
        agent.speed = enemySO.Speed;
        agent.angularSpeed = enemySO.AngularRotationSpeed;
        agent.stoppingDistance = enemySO.AgentStoppingDistance;
        zeroMagnitude = enemySO.IdleMaxMagnitude;
    }

    private void Persuit()
    {
        if (ableToMove && persutedTarget != null)
        {
            agent.destination = persutedTarget.position;
        }
    }

    public override bool IsWalking()
    {
        return agent.velocity.magnitude > zeroMagnitude;
    }

    public override void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
