using UnityEngine;

public class PlinkoLights : MonoBehaviour
{
    [Header("Cubes")]
    public GameObject plinkoTrigger;

    public Material plinkoEmission;
    public Material plinkoNormal;

    public MeshRenderer triggerRender;

    void Start()
    {
        triggerRender = plinkoTrigger.GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlinkoToken")
        {
            triggerRender.material = plinkoEmission;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PlinkoToken")
        {
            triggerRender.material = plinkoNormal;
        }
    }
}
