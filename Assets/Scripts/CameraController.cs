using UnityEngine;
using UnityEngine.Rendering;

public class CameraController : MonoBehaviour

{
    public float mouseSensitivity = 90;

    private float xRotation;
    private float mouseX;
    private float mouseY;

    private void Start()
    {
        xRotation = 0;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Update()
    {
        if (Time.time < 0.5f)
            return;
        //get mouse input
        //Time.deltaTime is time between previous frame, Time.time is seconds elapsed
        mouseX += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY += Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        //rotate player around y axis, camera around x axis

    }
    private void FixedUpdate()
    {
        transform.parent.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        mouseX = 0;
        mouseY = 0;
    }
}
