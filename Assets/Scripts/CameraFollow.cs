using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Camera _camera;
    static readonly Vector3 CAMERA_OFFSET = new(0,1,-6);
    private float _baseCameraFOV = 60f;
    private float _refVelocity = 0f;

    void Update()
    {
        if (!GameManager.IsDead)
        {
            _camera.fieldOfView = Mathf.SmoothDamp(_camera.fieldOfView, _baseCameraFOV * GameGlobals.TimeFactor, ref _refVelocity, 0.2f);
        }
    }

    void FixedUpdate()
    {
        transform.position = _playerTransform.position + CAMERA_OFFSET;
    }
}
