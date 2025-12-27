using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Camera _camera;
    static readonly Vector3 CAMERA_OFFSET = new(0,1,-6);
    static readonly float INITIAL_CAMERA_FOV = 40f;
    static readonly float BASE_CAMERA_FOV = 60f;
    private float _refVelocity = 0f;

    void Update()
    {
        if (!GameManager.IsDead)
        {
            _camera.fieldOfView = Mathf.SmoothDamp(_camera.fieldOfView, BASE_CAMERA_FOV * GameGlobals.TimeFactor, ref _refVelocity, 0.2f);
        }
        else if (_camera.fieldOfView != INITIAL_CAMERA_FOV)     // IsDead and isn't back to _initialCameraFOV
        {
            _camera.fieldOfView = Mathf.SmoothDamp(_camera.fieldOfView, INITIAL_CAMERA_FOV, ref _refVelocity, 0.1f);
        }
    }

    void FixedUpdate()
    {
        transform.position = _playerTransform.position + CAMERA_OFFSET;
    }
}
