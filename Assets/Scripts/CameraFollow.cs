using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Camera _camera;
    static readonly Vector3 CAMERA_OFFSET = new(0,1,-6);
    static readonly float INITIAL_CAMERA_FOV = 60f;
    private float _refVelocity = 0f;

    void Update()
    {
        _camera.fieldOfView = Mathf.SmoothDamp(_camera.fieldOfView, INITIAL_CAMERA_FOV * GameGlobals.TimeFactor, ref _refVelocity, 0.2f);
    }

    void FixedUpdate()
    {
        transform.position = _playerTransform.position + CAMERA_OFFSET;
    }
}
