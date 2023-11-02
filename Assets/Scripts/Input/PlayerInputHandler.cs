using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Implementations for player input
public class PlayerInputHandler : MonoBehaviour
{
    private PlayerActions input = null;
    private Vector2 moveVector = Vector2.zero;
    private Rigidbody2D rb = null;
    public float moveSpeed = 10f;

    private void Awake() {
        input = new PlayerActions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable() {
        input.Enable();
        input.PlayerControls.Move.performed += OnMove;
        input.PlayerControls.Move.canceled += OnMoveCanceled;
    }

    private void OnDisable() {
        input.Disable();
        input.PlayerControls.Move.performed -= OnMove;
        input.PlayerControls.Move.canceled -= OnMoveCanceled;
    }

    private void FixedUpdate() {
        rb.velocity = moveVector * moveSpeed;
    }

    private void OnMove(InputAction.CallbackContext context) {
        moveVector = context.ReadValue<Vector2>();
    }

    private void OnMoveCanceled(InputAction.CallbackContext context) {
        moveVector = Vector2.zero;
    }
}
