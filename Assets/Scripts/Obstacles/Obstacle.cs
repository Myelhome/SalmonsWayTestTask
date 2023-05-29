using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

public class Obstacle : MonoBehaviour
{
    [SerializeField] ObstacleSO obstacleSO;

    private NavMeshObstacle navMeshObsticle;
    private Collider[] coliders;
    private Rigidbody rb;

    public ObstacleSO ObstacleSO { get => obstacleSO; set => obstacleSO = value; }

    private void Awake()
    {
        navMeshObsticle = GetComponent<NavMeshObstacle>();
        coliders = GetComponents<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        AsyncStart();
    }

    private async void AsyncStart()
    {
        navMeshObsticle.enabled = false;

        rb.isKinematic = true;

        foreach (var colider in coliders) colider.enabled = false;

        navMeshObsticle.carving = true;
        navMeshObsticle.carveOnlyStationary = false;

        await AwaitBeforeExist();

        //workaround to chceck if object is destroyed while awaited
        if (navMeshObsticle != null)
        {
            navMeshObsticle.enabled = true;
            rb.isKinematic = false;
            foreach (var colider in coliders) colider.enabled = true;
        }
    }

    private async Task AwaitBeforeExist()
    {
        await Task.Delay(1000);
    }
}
