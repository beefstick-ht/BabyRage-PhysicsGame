using UnityEngine;

public class ShapesNColors : MonoBehaviour
{
    [Header("Cubes")]
    public GameObject redCube;
    public GameObject blueCube;
    public GameObject greenCube;

    public bool redActive;
    public bool blueActive;
    public bool greenActive;

    public GameObject redButton;
    public GameObject greenButton;
    public GameObject blueButton;

    public Material redEmission;
    public Material redNormal;
    public Material blueEmission;
    public Material blueNormal;
    public Material greenEmission;
    public Material greenNormal;

    public MeshRenderer redRenderer;
    public MeshRenderer blueRenderer;
    public MeshRenderer greenRenderer;

    public GameObject door;

    void Start()
    {
        redActive = false;
        blueActive = false;
        greenActive = false;

        redRenderer = redButton.GetComponent<MeshRenderer>();
        blueRenderer = blueButton.GetComponent<MeshRenderer>();
        greenRenderer = greenButton.GetComponent<MeshRenderer>();
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
            redRenderer.material = redEmission;
        }
        if (other.tag == "BlueCube")
        {
            Debug.Log("gwopt");
            blueActive = true;
            blueRenderer.material = blueEmission;

        }
        if (other.tag == "GreenCube")
        {
            Debug.Log("blunk");
            greenActive = true;
            greenRenderer.material = greenEmission;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "GreenCube")
        {
            Debug.Log("blunk");
            greenActive = false;
            greenRenderer.material = greenNormal;
        }
    }
}
