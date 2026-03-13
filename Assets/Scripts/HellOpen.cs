using UnityEngine;

public class HellOpen : MonoBehaviour
{
    public GameObject door;

    public Camera camera;

    private void Start()
    {
        camera.GetComponent<Skybox>().enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.SetActive(false);
            camera.GetComponent<Skybox>().enabled = false;
        }
    }
}
