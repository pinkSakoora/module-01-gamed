using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] ObstacleSpawner _obstacleSpawner;
    public void OnDeath()
    {
        _obstacleSpawner.enabled = false;       // Disable this component to stop further spawning
        var spawnedObstacleList = FindObjectsByType<ObstacleMover>(FindObjectsSortMode.None);   // Make a list of all objects containing ObstacleMover
        for (int i = 0; i < spawnedObstacleList.Length; i++)                                    // component (all obstacles) and disable all of them
        {
            spawnedObstacleList[i].enabled = false;
        }
    }
}
