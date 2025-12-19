using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] float _obstacleMoveSpeed;
    private float _lifespan = 0;
    [SerializeField] float _maxLifespan;

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
        gameObject.transform.position = gameObject.transform.position - new Vector3(0, 0, _obstacleMoveSpeed * Time.deltaTime);
    }
}
