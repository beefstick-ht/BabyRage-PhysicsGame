using UnityEngine;
using UnityEngine.InputSystem;

public class MovementBehavior : MonoBehaviour
{
    public GameObject hand1;
    public Vector3 hand1Offset;
    public GameObject hand2;
    public Vector3 hand2Offset;

    public GameObject camera;

    public float distance;

    public LayerMask wallMask;

    void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            ClimbRight();
            Vector2 mousePosition = Mouse.current.position.ReadValue();
            Camera.main.ScreenPointToRay(mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //sets hand's parent to us
            hand1.transform.parent = transform;
            //sets hand's position to our position + hand offset (relative to our rotation)
            hand1.transform.position = transform.position + hand1Offset.x * transform.right + Vector3.up * hand1Offset.y + transform.forward * hand1Offset.z;
        }
        //transform.position is us

        if (Input.GetMouseButtonDown(1))
        {
            ClimbLeft();
        }
        if (Input.GetMouseButtonUp(1))
        {
            hand2.transform.parent = transform;
            hand2.transform.position = transform.position + hand2Offset.x * transform.right + Vector3.up * hand2Offset.y + transform.forward * hand2Offset.z;
        }

        Debug.DrawRay(camera.transform.position, camera.transform.forward * distance, Color.red);
    }

    private void ClimbRight()
    {
        RaycastHit hit;
        //see if wall is in front of us
        bool hitWall = Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance, wallMask);

        if (hitWall == true)
        {
            //if wall is there, set hand position to raycast on wall
            hand1.transform.position = hit.point;
            Debug.Log("hit");
            //set hand to have no parent so it won't move with us (stays on wall)
            hand1.transform.parent = null;
        }
    }
    private void ClimbLeft()
    {
        RaycastHit hit;
        //see if wall is in front of us
        bool hitWall = Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance, wallMask);

        if (hitWall == true)
        {
            //if wall is there, set hand position to raycast on wall
            hand2.transform.position = hit.point;
            Debug.Log("hit");
            //set hand to have no parent so it won't move with us (stays on wall)
            hand2.transform.parent = null;
        }
    }

}
