using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    /*
        Generate a new obstacle selected randomly from _obstacleList at transform.position every _spawnInterval seconds
    */
    [SerializeField] float _spawnInterval;
    [SerializeField] List<GameObject> _obstacleList;
    public float ObstacleMoveSpeed;

    private float _timeSinceSpawn = 0;

    void Update()
    {
        _timeSinceSpawn += Time.deltaTime;
        if (_timeSinceSpawn >= _spawnInterval)
        {
            _timeSinceSpawn = 0;
            GameObject obstacle = _obstacleList[Random.Range(0,_obstacleList.Count)];   // Initialize obstacle within function instead of globally
            Instantiate(obstacle, transform.position, Quaternion.identity);     // Create a new instance of _obstacle
        }
    }
}
