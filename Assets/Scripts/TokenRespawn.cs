using UnityEngine;

public class TokenRespawn : MonoBehaviour
{

    public GameObject respawnButton;
    public Transform plinkoRespawn;
    public bool buttonPressed;


    // Update is called once per frame
    void Update()
    {
        if(buttonPressed==true)
        {
            Spawn();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonPressed = true;
    }

    public void Spawn()
    {
        transform.position = plinkoRespawn.position;
    }
}
