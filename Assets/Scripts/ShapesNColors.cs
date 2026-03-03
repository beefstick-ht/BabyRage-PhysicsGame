using UnityEngine;

public class ShapesNColors : MonoBehaviour
{
    public GameObject redCube;
    public GameObject blueCube;
    public GameObject greenCube;
    public bool redActive;
    public bool blueActive;
    public bool greenActive;

    public GameObject redButton;
    public GameObject greenButton;
    public GameObject blueButton;

    public GameObject door;

    void Start()
    {
        redActive = false;
        blueActive = false;
        greenActive = false;

    
    }

    void Update()
    {
        if (redActive & blueActive & greenActive == true)
        {
            door.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedCube")
        {
            Debug.Log("fard");
            redActive = true;
        }
        if (other.tag == "BlueCube")
        {
            Debug.Log("gwopt");
            blueActive = true;
        }
        if (other.tag == "GreenCube")
        {
            Debug.Log("blunk");
            greenActive = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "GreenCube")
        {
            Debug.Log("blunk");
            greenActive = false;
        }
    }
}
