using UnityEngine;

public class RandomPlayerTargetUtils : TargetUtils
{
    private Player[] players;

    private void Start()
    {
        players = FindObjectsOfType<Player>();
    }

    public override Transform GetTarget(Transform[] targets)
    {
        if (targets == null || targets.Length == 0) return GetPlayerTarget();

        return base.GetTarget(targets);
    }

    private Transform GetPlayerTarget()
    {
        if (players.Length > 0) return players[Random.Range(0, players.Length)].transform;

        return null;
    }
}
