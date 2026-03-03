using UnityEngine;

public class ShapesNColors : MonoBehaviour
{
    public GameObject cube;
    public bool redActive;
    public bool blueActive;
    public bool greenActive;

    void Start()
    {
        redActive = false;
        blueActive = false;
        greenActive = false;
    }

    void Update()
    {
        
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

        Debug.Log("aw");
        redActive = false;

        Debug.Log("darn");
        blueActive = false;

        Debug.Log("sghoort");
        greenActive = false;
        
    }
}
