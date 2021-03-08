using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private Collider _collider;

    [SerializeField] private float _jumpForce = 300f;

    private bool _shouldJump;

    private float distToGround;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<Collider>();
        distToGround = _collider.bounds.extents.y;

    }



    private void Update()
    {
        if (_shouldJump == false && IsGrounded())
        {
            _shouldJump = Input.GetKeyDown(KeyCode.Space);
        }
    }

    private void FixedUpdate()
    {
        if (_shouldJump)
        {
            _rigidbody.AddForce(_jumpForce * Vector3.up);
            _shouldJump = false;
        }
    }

    private bool IsGrounded()
    {
        // Changer en BoxCast
        if (Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f))
        {
            return true;
        }
        return false;
    }
}
