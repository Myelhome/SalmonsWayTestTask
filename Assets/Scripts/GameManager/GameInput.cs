using UnityEngine;

//here i'd have prefer to use events to avoid doble update check or links to object affected by the input 
public class GameInput : MonoBehaviour
{
    private EnemySpawner enemySpawner;
    private ObstacleSpawner obstacleSpawner;

    private Player player;

    private void Start()
    {
        enemySpawner = FindAnyObjectByType<EnemySpawner>();
        obstacleSpawner = FindAnyObjectByType<ObstacleSpawner>();

        player = FindAnyObjectByType<Player>();    
    }

    void Update()
    {
        UpdateMoveDir();
        UpdateEnemySpawner();
        UpdateObstacleSpawner();
    }

    private void UpdateMoveDir()
    {
        var inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W)) inputVector.y++;
        if (Input.GetKey(KeyCode.S)) inputVector.y--;
        if (Input.GetKey(KeyCode.A)) inputVector.x--;
        if (Input.GetKey(KeyCode.D)) inputVector.x++;

        player.MoveDir = new Vector3(inputVector.x, 0, inputVector.y).normalized;
    }

    private void UpdateEnemySpawner()
    {
        if (Input.GetKeyDown(KeyCode.Space)) enemySpawner.SpawnEnemy();
    }

    private void UpdateObstacleSpawner()
    {
        if (Input.GetKeyDown(KeyCode.C)) obstacleSpawner.SpawnObstacle();
    }
}
