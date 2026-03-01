using UnityEngine;

public class ShapesNColors : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedSquare")
        {
            Debug.Log("fard");
        }
    }
}
