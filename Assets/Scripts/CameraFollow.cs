using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Vector3 _offset;

    void FixedUpdate()
    {
        transform.position = _playerTransform.position + _offset;
    }
}
