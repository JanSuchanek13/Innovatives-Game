using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public Vector2 moveInput { get; private set; } = Vector2.zero;
    public Vector2 sprintInput { get; private set; } = Vector2.zero;


    private PlayerInput _playerInput;

    private void OnEnable()
    {
        _playerInput = new PlayerInput();
        _playerInput.LowerBody.Enable();

        _playerInput.LowerBody.Move.performed += SetMove;
        _playerInput.LowerBody.Move.canceled += SetMove;

        _playerInput.LowerBody.Sprint.performed += SetSprint;
        _playerInput.LowerBody.Sprint.canceled += SetSprint;
    }
    private void OnDisable()
    {
        _playerInput.LowerBody.Move.performed -= SetMove;
        _playerInput.LowerBody.Move.canceled -= SetMove;

        _playerInput.LowerBody.Sprint.performed += SetSprint;
        _playerInput.LowerBody.Sprint.canceled += SetSprint;

        _playerInput.LowerBody.Disable();
    }

    private void SetMove(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
    }
    private void SetSprint(InputAction.CallbackContext ctx)
    {
        sprintInput = ctx.ReadValue<Vector2>();
    }
}
