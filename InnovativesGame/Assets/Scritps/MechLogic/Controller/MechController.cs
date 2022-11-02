using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechController : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField] InputHandler _input;

    Vector3 _playerMoveInput = Vector3.zero;

    [Header("Movement")]
    [SerializeField] float _movementMultiplier = 30.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _playerMoveInput = GetMoveInput();
        PlayerMove();

        _rigidBody.AddRelativeForce(_playerMoveInput, ForceMode.Force);
    }
    private Vector3 GetMoveInput()
    {
        return new Vector3(_input.moveInput.x, 0.0f, _input.moveInput.y);
    }
    private void PlayerMove()
    {
        _playerMoveInput = (new Vector3(_playerMoveInput.x * _movementMultiplier * _rigidBody.mass,
                                        _playerMoveInput.y,
                                        _playerMoveInput.z * _movementMultiplier * _rigidBody.mass));
    }

}
