using UnityEngine;

public class ShapesNColors : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called once before the first execution of Update after the MonoBehaviour is created
=======



>>>>>>> Stashed changes
    void Start()
    {
        
    }

<<<<<<< Updated upstream
    // Update is called once per frame
=======
  
>>>>>>> Stashed changes
    void Update()
    {
        
    }
<<<<<<< Updated upstream
=======

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedSquare")
        {
            GetComponent<Renderer>().color = Color.white;
        }
    }
>>>>>>> Stashed changes
}
