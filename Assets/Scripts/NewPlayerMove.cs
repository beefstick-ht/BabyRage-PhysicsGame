using UnityEngine;
using UnityEngine.InputSystem;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class NewPlayerMove : MonoBehaviour
{
    public float moveSpeed = 12;
    public float jumpForce = 50f;
    public Rigidbody rb;

    public float groundCheckRadius = 0.15f; //how far off the ground is grounded?
    public LayerMask groundLayer;
    public bool isGrounded;
    private Transform feet;

    public ForceMode forceMode;

    private Vector3 movement;




    private void Awake()
    {
        feet = transform.Find("feet");

    }

    private void Update()
    {
        CheckIsGrounded();
        Move();


        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + movement);
        movement = Vector3.zero;
        //compiles movement to one frame
    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;
        movement += move;
     //   rb.linearVelocity = move;
    }

    private void CheckIsGrounded()
    {
        isGrounded = Physics.CheckSphere(feet.position, groundCheckRadius, groundLayer);
    }
}
