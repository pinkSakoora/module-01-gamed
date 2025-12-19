using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] float _obstacleMoveSpeed;

    void FixedUpdate()
    {
        MoveObstacle();
    }

    void MoveObstacle()             // Modifying the transforms directly instead of using a rigidbody is doable.
    {                               // Fetch current transform, subtract by _obstacleMoveSpeed
        gameObject.transform.position = gameObject.transform.position - new Vector3(0,0,_obstacleMoveSpeed * Time.deltaTime);
    }
}
