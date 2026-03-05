using UnityEngine;

public class HellOpen : MonoBehaviour
{
    public GameObject door;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.SetActive(false);
        }
    }
}
