using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Moves the player in 2D space according to an input action (arrow keys).
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [Header("Input")]
    [Tooltip("Vector2 action, bound to the arrow keys")]
    [SerializeField] private InputAction moveAction;

    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D body;
    private Vector2 moveInput;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        body.linearVelocity = moveInput * moveSpeed;
    }
}