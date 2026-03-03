using UnityEngine;

public class ShapesNColors : MonoBehaviour
{
    public GameObject cube; 

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedCube")
        {
            Debug.Log("fard");

        }
    }
}
