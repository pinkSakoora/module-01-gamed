using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;

    void FixedUpdate()
    {
        transform.position = _playerTransform.position + GameGlobals.CAMERA_OFFSET;
    }
}
