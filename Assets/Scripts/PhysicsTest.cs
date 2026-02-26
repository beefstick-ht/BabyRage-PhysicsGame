using UnityEngine;
using UnityEngine.InputSystem;

public class PhysicsTest : MonoBehaviour
{
    public float jumpForce;
    public ForceMode forceMode;
    public float moveSpeed;


    private Rigidbody rb;
    Vector3 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            movement += Vector3.down * Time.deltaTime;
            movement += transform.position * Time.deltaTime;
        }

        #region[glorble]
        //rb.MovePosition(transform.position + (Vector3.down * 3 * Time.deltaTime)); //will NOT move through obj; put only in fixedupdate method
        //transform.Translate(Vector3.down * Time.deltaTime); //disconnected from physics, will move through objects
        //if(Input.GetKeyDown(KeyCode.Space))
        {

        }
        #endregion
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + movement);
        movement = Vector3.zero;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.up * jumpForce, forceMode);
        //if you want it to spin: rb.AddTorque(Vector3.right * jumpForce);
        Debug.Log("jumpy");
    }

    public void OnCollisionEner(Collision collision)
    {
        Debug.Log($"velocity: {rb.linearVelocity.magnitude}");
        if(rb.linearVelocity.magnitude > 1) 
        {
            Debug.Log("ow");
        }
        //to detect a certain spin speed if (rb.angularVelocity.magnitude > 8) 
    }
}
