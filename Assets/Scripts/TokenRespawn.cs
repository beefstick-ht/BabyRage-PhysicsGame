using UnityEngine;

public class TokenRespawn : MonoBehaviour
{

    public GameObject respawnButton;
    public Transform plinkoRespawn;
    public bool buttonPressed;
    public GameObject token;


    // Update is called once per frame
    void FixedUpdate()
    {
        if(buttonPressed==true)
        {
            Spawn();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
        buttonPressed = true;
        }

    }

    public void Spawn()
    {
        token.transform.position = plinkoRespawn.position;
        buttonPressed = false;
        token.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    }
}
