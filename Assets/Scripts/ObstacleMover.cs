using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    private float _lifespan = 0;
    private float _maxLifespan = GameGlobals.OBSTACLE_SPAWN_POINT.z/(GameGlobals.OBSTACLE_MOVE_SPEED * GameGlobals.TimeFactor);

    void Update()
    {
        _lifespan += Time.deltaTime;
        if (_lifespan >= _maxLifespan)
        {
            Destroy(gameObject);                // Destroy current obstacle when its _lifespan is above _maxLifespan
        }
    }

    void FixedUpdate()
    {
        MoveObstacle();
    }

    void MoveObstacle()             // Modifying the transforms directly instead of using a rigidbody is doable.
    {                               // Fetch current transform, subtract by _obstacleMoveSpeed
        transform.position = transform.position - new Vector3(0, 0, GameGlobals.OBSTACLE_MOVE_SPEED * Time.deltaTime * GameGlobals.TimeFactor);
    }
}
