using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] float checkpointTimeExtension = 5f;
    [SerializeField] float obstacleDecreaseTimeAmount = .2f;

    GameManager gameManager;
    ObstacleSpawner obstacleSpawner;

    const string playerString = "Player";

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        obstacleSpawner = FindAnyObjectByType<ObstacleSpawner>();
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag(playerString)) 
        {
            gameManager.IncreaseTime(checkpointTimeExtension);
            obstacleSpawner.DecreaseObstacleSpawnTime(obstacleDecreaseTimeAmount);
        }    
    }
}
