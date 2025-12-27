using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    /*
        Generate a new obstacle selected randomly from _obstacleList at transform.position every _spawnInterval seconds
    */
    private float _spawnInterval => GameGlobals.OBSTACLE_LENGTH/(GameGlobals.OBSTACLE_MOVE_SPEED * GameGlobals.TimeFactor);
    [SerializeField] List<GameObject> _obstacleList;

    private float _timeSinceSpawn;

    void Start()
    {
        _timeSinceSpawn = 0;
    }

    void Update()
    {
        _timeSinceSpawn += Time.deltaTime;
        if (_timeSinceSpawn >= _spawnInterval)
        {
            _timeSinceSpawn = 0;
            GameObject obstacle = _obstacleList[Random.Range(0,_obstacleList.Count)];   // Initialize obstacle within function instead of globally
            Instantiate(obstacle, GameGlobals.OBSTACLE_SPAWN_POINT, Quaternion.identity);     // Create a new instance of _obstacle
        }
    }
}
