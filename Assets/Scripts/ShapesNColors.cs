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
        if (other.tag == "Player")
        {
            Debug.Log("fard");
            var cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
    }
}
