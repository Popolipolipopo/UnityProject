using UnityEngine;

public class CompletePlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private float _movementForce = 10f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
            _rigidbody.AddForce(_movementForce * Vector3.left);
        if (Input.GetKey(KeyCode.D))
            _rigidbody.AddForce(_movementForce * Vector3.right);
    }
}