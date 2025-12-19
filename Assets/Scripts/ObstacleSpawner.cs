using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    /*
        Generate a new _obstacle at gameObject.transform.position every _spawnInterval seconds
    */
    [SerializeField] float _spawnInterval;
    [SerializeField] GameObject _obstacle;

    private float _timeSinceSpawn = 0;

    void Update()
    {
        _timeSinceSpawn += Time.deltaTime;
        if (_timeSinceSpawn >= _spawnInterval)
        {
            _timeSinceSpawn = 0;
            Instantiate(_obstacle, gameObject.transform.position, Quaternion.identity);     // Create a new instance of _obstacle
        }   
    }
}
