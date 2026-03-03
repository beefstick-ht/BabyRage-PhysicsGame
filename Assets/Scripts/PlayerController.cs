using UnityEngine;
using UnityEngine.InputSystem;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 12;
    private float jumpForce = 5f;
    public Rigidbody rb;

    public float gravity = 9.8f; //player gravity
    public float groundCheckRadius = 0.15f; //how far off the ground is grounded?
    public LayerMask groundLayer;
    public bool isGrounded;
    private Transform feet;

    public ForceMode forceMode;

    private Vector3 velocity;


    private CharacterController controller;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        feet = transform.Find("feet");

    }

    private void Update()
    {
        CheckIsGrounded();
        Move();
        ApplyGravity();

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }


    private void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move);
    }

    private void CheckIsGrounded()
    {
        isGrounded = Physics.CheckSphere(feet.position, groundCheckRadius, groundLayer);
    }


    private void ApplyGravity()
    {
        velocity += Vector3.down * gravity * Time.deltaTime;

        if (isGrounded)
        {
            velocity = Vector3.zero;
        }

        controller.Move(velocity); 
    }
}
