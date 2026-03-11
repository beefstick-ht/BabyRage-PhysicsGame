using UnityEngine;

public class BabyShapes : MonoBehaviour
{
    public bool boxActive;
    public bool cylinderActive;
    public bool triangleActive;
    public bool d20Active;
    public bool pentagonActive;

    public GameObject door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pentagonActive & d20Active & triangleActive & cylinderActive & boxActive == true)
        {
            door.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SnCBox")
        {
            boxActive = true;
            Debug.Log("box active");
        }
        if (other.tag == "SnCCylinder")
        {
            cylinderActive = true;
            Debug.Log("cylinder active");

        }
        if (other.tag == "SnCTriangle")
        {
            triangleActive = true;
            Debug.Log("triangle active");
        }
        if (other.tag == "SnCPentagon")
        {
            pentagonActive = true;
            Debug.Log("pentagon active");
        }
        if (other.tag == "SnCD20")
        {
            d20Active = true;
            Debug.Log("d20 active");
        }
    }
}
