using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputAction _sidewaysAction;           // We're using the new Input System which is the default for new editor versions
    [SerializeField] Rigidbody _rb;                         // [SerializeField] forces a private property to show up in the Editor
    private float _sidewaysAmt;
    [SerializeField] float _moveSpeed;

    void OnEnable()                                         // Enable InputAction on enabling the script
    {
        _sidewaysAction.Enable();
    }

    void OnDisable()                                        // Disable InputAction on disabling the script
    {
        _sidewaysAction.Disable();
    }

    void Update()                                           // Get user input in the Update() function to ensure least input lag as
    {                                                       // Update() is called every frame
        GetInput();
    }

    void FixedUpdate()                                      // Apply physics manipulations in FixedUpdate() as it is called a fixed
    {                                                       // number of times per second, ensuring consistency across different framerates
        SidewaysMovement();
    }

    void GetInput()
    {
        _sidewaysAmt = _sidewaysAction.ReadValue<float>();  // _sidewaysAction ranges from -1 to 1, this is then casted to float type and fed 
    }                                                       // into _sidewaysAmt

    void SidewaysMovement()
    {
        _rb.AddForce(new Vector3(_sidewaysAmt * _moveSpeed, 0, 0));     // Add a force only in X direction.
    }
}
